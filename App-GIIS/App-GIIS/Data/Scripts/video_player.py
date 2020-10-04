# python video_player.py --video data/slayer.mp4 --subtitle data/slayer.srt
import os
import numpy as np
import cv2
import argparse
import datetime
import time
import threading
import multiprocessing
import pysrt
import moviepy.editor as mp
from playsound import playsound
import tqdm


def subtitle_processing(src):
    subs = pysrt.open(args['subtitle'])
    subtitle_frames = np.array([[sub.start.ordinal, sub.end.ordinal] for sub in subs])
    subtitle_frames = (src.get(cv2.CAP_PROP_FPS) / 1000 * subtitle_frames).astype(int)
    subtitle_text = np.array([sub.text for sub in subs])
    return subtitle_text, subtitle_frames


def convert_to_audio(path_video, type_audio):
    clip = mp.AudioFileClip(path_video)
    filename, file_extension = os.path.splitext(path_video)
    clip.write_audiofile(f'{filename}.{type_audio}')
    print(f'[INFO][Audio] Created {filename}.{type_audio}')
    path = os.path.join(os.path.abspath(os.path.dirname(__file__)), f'{filename}.{type_audio}')
    return f'{filename}.{type_audio}', path


def video_processing(frame, frame_num):
    global index
    y0, dy = 300, 30
    font = cv2.FONT_HERSHEY_COMPLEX_SMALL
    fontScale = 1
    color = (255, 255, 255)
    color2 = (0, 0, 0)
    frame = cv2.resize(frame, (640, 360))
    if subtitle_frames[index][0] <= frame_num <= subtitle_frames[index][1]:
        for i, text in enumerate(subtitle_text[index].split('\n')):
            y = y0 + i * dy
            text_size = cv2.getTextSize(text, font, 1, 2)[0]
            text_x = int((frame.shape[1] - text_size[0]) / 2)
            cv2.rectangle(frame, (text_x, y + 5), (text_x + text_size[0], y - 25), color2, -1)
            cv2.putText(frame, text, (text_x, y), font, fontScale, color, thickness=1)
    elif index < (len(subtitle_text) - 1) and subtitle_frames[index + 1][0] <= frame_num <= subtitle_frames[index + 1][
        1]:
        index += 1
        for i, text in enumerate(subtitle_text[index].split('\n')):
            y = y0 + i * dy
            text_size = cv2.getTextSize(text, font, 1, 2)[0]
            text_x = int((frame.shape[1] - text_size[0]) / 2)
            cv2.rectangle(frame, (text_x, y + 5), (text_x + text_size[0], y - 25), color2, -1)
            cv2.putText(frame, text, (text_x, y), font, fontScale, color, thickness=1)
    (h, w) = frame.shape[:2]
    (B, G, R) = cv2.split(frame)
    zeros = np.zeros((h, w), dtype="uint8")
    R = cv2.merge([zeros, zeros, R])
    G = cv2.merge([zeros, G, zeros])
    B = cv2.merge([B, zeros, zeros])
    output = np.zeros((h * 2, w * 2, 3), dtype="uint8")
    output[0:h, 0:w] = frame
    output[0:h, w:w * 2] = R
    output[h:h * 2, w:w * 2] = G
    output[h:h * 2, 0:w] = B
    return output


if __name__ == "__main__":
    ap = argparse.ArgumentParser()
    ap.add_argument("-v", "--video", required=True,
                    help="path to the video")
    ap.add_argument("-s", "--subtitle", required=True,
                    help="path to the subtitle")
    args = vars(ap.parse_args())
    video = cv2.VideoCapture(args['video'])
    subtitle_text, subtitle_frames = subtitle_processing(video)
    index = 0
    index_frames = 1
    millisecond = 875
    fps = video.get(cv2.CAP_PROP_FPS)
    avg_frame = video.get(cv2.CAP_PROP_FPS)
    print(f'[INFO][Video] Number of frames: {video.get(cv2.CAP_PROP_FRAME_COUNT)}')
    print(f'[INFO][Video] FPS value: {video.get(cv2.CAP_PROP_FPS)}')
    print(f'[INFO][Video] Duration: {video.get(cv2.CAP_PROP_FRAME_COUNT) / video.get(cv2.CAP_PROP_FPS)}')
    audiofile, path = convert_to_audio(args['video'], 'wav')
    audio_process = multiprocessing.Process(target=playsound, args=(audiofile,))
    audio_process.start()
    print("[INFO][Video] Start of video")
    time_start = datetime.datetime.today().timestamp()
    for index_frames in tqdm.tqdm(range(int(video.get(cv2.CAP_PROP_FRAME_COUNT)))):
        ret, frame = video.read()
        frame = video_processing(frame, index_frames)
        cv2.imshow("Video Player", frame)
        if fps > avg_frame > 0:
            ms_frames = 820 / avg_frame
        else:
            ms_frames = 875 / fps
        time_diff = datetime.datetime.today().timestamp() - time_start
        avg_frame = index_frames / time_diff
        if cv2.waitKey(int(ms_frames)) & 0XFF == ord('q'):
            audio_process.terminate()
            break
    time_end = datetime.datetime.today().timestamp()
    print(f"[INFO][Video] End of video")
    print(f"[INFO][Video] Video time: {time_end - time_start}")
    audio_process.terminate()
    audio_process.kill()
    os.remove(path)
    print(f'[INFO][Audio] Deleted {audiofile}')
    video.release()
    cv2.destroyAllWindows()

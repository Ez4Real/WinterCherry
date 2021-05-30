import { createStore, createEvent, createEffect } from "effector";
import { roomImages } from "../api/roomImage";
import { IRoomImages } from "../api/types";

export const $roomImages = createStore<IRoomImages[]>([]);

export const updateRoomImages = createEvent<IRoomImages>();

export const reset = createEvent();
export const roomImagesFx = createEffect(roomImages);

$roomImages.on(roomImagesFx.doneData, (_, data) => {
  console.log(data);
  return data;
});

$roomImages.reset(reset);

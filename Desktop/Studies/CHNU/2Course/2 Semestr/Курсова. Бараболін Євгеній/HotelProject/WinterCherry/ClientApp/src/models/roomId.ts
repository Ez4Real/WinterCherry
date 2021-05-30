import { createStore, createEvent } from "effector";

export const $roomSelectedId = createStore<Number>(0);
export const $drawerShow = createStore<boolean>(false);

export const updateSelectedRoom = createEvent<Number>();
export const updateDrawerShow = createEvent<boolean>();

$roomSelectedId.on(updateSelectedRoom, (_, data) => data);

$drawerShow.on(updateDrawerShow, (_, data) => data);

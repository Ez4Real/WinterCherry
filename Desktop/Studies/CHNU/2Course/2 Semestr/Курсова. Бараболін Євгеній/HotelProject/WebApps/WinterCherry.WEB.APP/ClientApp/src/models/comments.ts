import { createStore, createEvent, createEffect } from "effector";
import { comments } from "../api/comments";
import { IComment } from "../api/types";

export const $comments = createStore<IComment[]>([]);

export const updateComments = createEvent<IComment>();

export const reset = createEvent();
export const commentsFx = createEffect(comments);

$comments.on(commentsFx.doneData, (_, data) => {
  console.log(data);
  return data;
});

$comments.reset(reset);

import { createStore, createEvent, createEffect } from "effector";
import { catalog } from "../api/catalog";
import { ICatalog } from "../api/types";

export const $catalog = createStore<ICatalog[]>([]);

export const updateCatalog = createEvent<ICatalog>();

export const reset = createEvent();
export const catalogDataFx = createEffect(catalog);

$catalog.on(catalogDataFx.doneData, (_, data) => {
  console.log(data);
  return data;
});

$catalog.reset(reset);

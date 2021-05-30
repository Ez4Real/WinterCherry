import axios from "axios";

export async function catalog() {
  let res = await axios.get("/stub/Rooms.json");
  return res.data;
}

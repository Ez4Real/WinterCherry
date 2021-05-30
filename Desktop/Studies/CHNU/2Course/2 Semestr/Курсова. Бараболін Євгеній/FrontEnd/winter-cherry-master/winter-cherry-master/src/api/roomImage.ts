import axios from "axios";

export async function roomImages() {
  let res = await axios.get("/stub/RoomsImages.json");
  return res.data;
}

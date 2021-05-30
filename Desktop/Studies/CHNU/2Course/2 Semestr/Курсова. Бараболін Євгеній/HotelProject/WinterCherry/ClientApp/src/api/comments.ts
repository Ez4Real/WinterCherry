import axios from "axios";

export async function comments() {
  let res = await axios.get("/stub/comments.json");
  return res.data;
}

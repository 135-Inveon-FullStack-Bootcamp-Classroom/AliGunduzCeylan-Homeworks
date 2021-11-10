import { createSlice } from "@reduxjs/toolkit";

export const memesSlice = createSlice({
    name: 'memes',
    initialState: {
        cards: [{}]
    },
})

export default memesSlice.reducer;
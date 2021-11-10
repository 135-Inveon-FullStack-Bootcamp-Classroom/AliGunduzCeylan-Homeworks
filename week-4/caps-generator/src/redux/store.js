import { configureStore } from "@reduxjs/toolkit";
import memesReducer from "./memes/memesSlice";

export const store = configureStore({
    reducer: {
        memes: memesReducer,
    },
});
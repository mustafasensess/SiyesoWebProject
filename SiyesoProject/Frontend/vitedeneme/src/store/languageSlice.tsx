import { createSlice } from '@reduxjs/toolkit';

interface aboutState{
    value: string;
}
const initialState: aboutState = {
    value: "Türkçe",
};

const languageSlice = createSlice({
    name: 'about',
    initialState,
    reducers: {
        turkish: (state) => {
            state.value = "Türkçe";
        },
        english: (state) => {
            state.value = "English";
        },

    },
});

export const { turkish, english } = languageSlice.actions;

// Reducer'ı export ediyoruz
export default languageSlice.reducer;
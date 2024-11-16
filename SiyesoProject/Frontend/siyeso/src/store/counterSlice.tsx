import { createSlice, PayloadAction } from '@reduxjs/toolkit';

// State'in tipi
interface CounterState {
    value: number;
}

// Başlangıç durumu
const initialState: CounterState = {
    value: 0,
};

const counterSlice = createSlice({
    name: 'counter',
    initialState,
    reducers: {
        increment: (state) => {
            state.value += 1; // Arttırma işlemi
        },
        decrement: (state) => {
            state.value -= 1; // Azaltma işlemi
        },
        incrementByAmount: (state, action: PayloadAction<number>) => {
            state.value += action.payload; // Belirli bir miktar ekleme
        },
    },
});

// Aksiyonları export ediyoruz
export const { increment, decrement, incrementByAmount } = counterSlice.actions;

// Reducer'ı export ediyoruz
export default counterSlice.reducer;
import { configureStore } from '@reduxjs/toolkit';
import counterReducer from './counterSlice';

const store = configureStore({
    reducer: {
        counter: counterReducer,
    },
});

// Store'un tiplerini tanımlıyoruz
export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;

export default store;
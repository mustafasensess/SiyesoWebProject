import { configureStore } from '@reduxjs/toolkit';
import aboutReducer from './languageSlice.tsx';

const store = configureStore({
    reducer: {
        about: aboutReducer,
    },
});

// Store'un tiplerini tanımlıyoruz
export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;

export default store;
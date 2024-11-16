import React from "react";
import { useSelector, useDispatch } from 'react-redux';
import {decrement, increment, incrementByAmount} from "./store/counterSlice.tsx";
import {AppDispatch, RootState} from "./store/store.tsx";



const Counter: React.FC = () => {
    const count = useSelector((state: RootState) => state.counter.value); // Redux state'e erişim
    const dispatch: AppDispatch = useDispatch(); // Redux dispatch

    return (
        <div>
            <h1>Count: {count}</h1>
            <button onClick={() => dispatch(increment())}>Increment</button>
            <button onClick={() => dispatch(decrement())}>Decrement</button>
            <button onClick={() => dispatch(incrementByAmount(5))}>Add 5</button>
        </div>
    );
};

export default Counter;
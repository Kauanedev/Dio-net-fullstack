"use client";
import {useParams} from "next/navigation";
export default function Produto() {

    const {id} = useParams();

    return (
        <div>
            <h1>Produto {id} </h1>
        </div>
    );
}
import React, { useState,useEffect } from 'react'
import { useParams } from 'react-router-dom'

function ProductDetails() {

    const {id} = useParams
    const [data,setData] = useState([]);

    useEffect( () => {
        fetch(`https://fakestoreapi.com/products/1`)
        .then(res => res.json()).then(id =>setData(id));
        console.log(setData);
      },[id]);


  return (
    <div>
        Urun Baslık
        
      {data.map (() => (
            <div>{data.title} </div>
      ))
    }
    </div>
  )
}

export default ProductDetails

import { useQuery } from '@chakra-ui/react';
import React from 'react'
import { useParams } from 'react-router-dom'

import { useState,useEffect } from "react";



function ProductDetails() {
  const [data,setData] = useState([]);

  useEffect(()=> {
    fetch(`https://localhost:5001/api/Books/${id}`)
    .then(res => res.json()).then(data =>setData(data));
  },[data]);

    const {id} = useParams();

    
    // const{isLoading, isError, data} = useQuery(['product', bookTitle] , () => fakes(id) );
    console.log(data);
    

  return (
    <div>
        {data.bookTitle}
        {data.price}
        {data.publisher}
        {id}
    </div>

  )
}

export default ProductDetails

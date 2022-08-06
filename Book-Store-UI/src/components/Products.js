import { useState,useEffect } from "react";
import React from 'react'
import Cards from "./Cards";
import { Grid } from '@chakra-ui/react';


function Products() {
    const [data,setData] = useState([]);

    useEffect(()=> {
      fetch(`https://localhost:5001/api/Books/`)
      .then(res => res.json()).then(data =>setData(data));
    },[data]);

  return (
    
      <div className='cards '>
        <Grid templateColumns='repeat(3, 1fr)' gap={3}>
        {
            data.map ((item,key) => (
                
                <Cards key={key} item={item} />
                
                
            ))
        }
        </Grid>
        </div>
    
  )
}

export default Products

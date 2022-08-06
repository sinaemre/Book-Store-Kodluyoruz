import { useQuery } from '@chakra-ui/react';
import React from 'react'
import { useParams } from 'react-router-dom'
import fakes from './fakes';
 

function ProductDetails() {

    const {id} = useParams();

    const{isLoading, isError, data} = useQuery(['product', id] , () => fakes(id) );

    
console.log(data);

  return (
    <div>
        {id}
    </div>

  )
}

export default ProductDetails

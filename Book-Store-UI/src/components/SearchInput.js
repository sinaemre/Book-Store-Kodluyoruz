import React from 'react'
import { Input } from '@chakra-ui/react'
import { useState } from 'react';


function SearchInput() {

  const [word, setWord] = useState('');

  const handleChange = (e) => {
    setWord(e.target.value);
    
  }
 
   return (
    <div className='inputSearch'>
      <Input placeholder='Kitap adı giriniz...' htmlSize={4} width='40%' onChange={handleChange} value={word}/>
    </div>
  )
}

export default SearchInput

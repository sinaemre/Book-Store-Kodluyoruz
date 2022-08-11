import React from 'react'
import { Input } from '@chakra-ui/react'
import { useState } from 'react';
import data from 'https://localhost:5001/api/Books'


function SearchInput() {

  const [word, setWord] = useState('');
  const bookList = data.jsonStringfy();
//   const bookList =[];
  const handleChange = (e) => {
    setWord(e.target.value);

   return (
    <div className='inputSearch'>
      <Input placeholder='Kitap adı giriniz...' htmlSize={4} width='40%' onChange={handleChange} value={word}/>
        {bookList.filter(item => {
            if (!word) return true
            if (item.bookTitle.includes(word)) {
              return true
            }
          })
          .map(item => (
            <div>
              <h1>{item.bookTitle}</h1>
            </div>
          ))
        }
    </div>
  )
  
      }
}
export default SearchInput
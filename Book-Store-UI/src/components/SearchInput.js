import React from 'react'
import { Input } from '@chakra-ui/react'

function SearchInput() {

   return (
    <div className='inputSearch'>
      <Input placeholder='Kitap adı giriniz...' htmlSize={4} width='40%' />
    </div>
  )
}

export default SearchInput

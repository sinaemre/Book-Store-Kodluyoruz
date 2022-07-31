import React from 'react'
import '../App.css' ;
import pic from "../img/book-store-logo.png";
import { Flex, Spacer,Button,ButtonGroup,Box,Heading } from '@chakra-ui/react'

function Header() {
  return (
    <div className='container'>
        <Flex minWidth='max-content' alignItems='center' gap='2'  mt={10}>
          <Box p='2'>
          <Heading size='md'>Book STORE</Heading>
          </Box>
          <Spacer />
        <ButtonGroup gap='2'>
        <Button colorScheme='teal'>Üye Ol</Button>
        <Button colorScheme='teal'>Giriş Yap</Button>
        </ButtonGroup>
      </Flex>
    </div>
  )
}

export default Header;
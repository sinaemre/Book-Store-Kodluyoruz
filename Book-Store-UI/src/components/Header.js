import React from 'react'
import '../App.css' ;
import { useNavigate } from 'react-router-dom';
import { Flex, Spacer,Button,ButtonGroup,Box,Heading } from '@chakra-ui/react'


function Header() {

  let navigate = useNavigate(); 
  const routeChange = () =>{ 
    let path = `/Login`; 
    navigate(path);
  }
  

  return (
    <div className='container'>
        <Flex minWidth='max-content' alignItems='center' gap='2'  mt={10}>
          <Box p='2'>
          <Heading size='md'>Book STORE</Heading>
          </Box>
          <Spacer />
        <ButtonGroup gap='2'>
          
        <Button colorScheme='teal' onClick={routeChange}>Üye Ol</Button>
        
        <Button colorScheme='teal'>Giriş Yap</Button>
        </ButtonGroup>
      </Flex>

     
    </div>
  )
}

export default Header;


import Card from 'react-bootstrap/Card';
import { Container } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';
import { Button } from '@chakra-ui/react'


function Cards( { item } ) {

  let navigate = useNavigate(); 
  const routeChange = () =>{ 
    let path = `/Products/${item.id}`; 
    navigate(path);
  }

  return (
    <div className='cards'>
    <Container  onClick={routeChange}>
     
      
        <Card style={{ width: '18rem' }}   >
          <Card.Img className='cardimage' variant="top" src={item.image} />
            <Card.Body className='cardbody' >
            <Card.Title >{item.title}</Card.Title>
            <Card.Text>Lorem ipsum dolor sit amet.</Card.Text>
          <Button colorScheme='teal'>Satın al</Button>
        </Card.Body>
      </Card>
    
    
    
    </Container>
    </div>
  );
}

export default Cards;

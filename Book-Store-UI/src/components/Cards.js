

import Card from 'react-bootstrap/Card';
import { Container } from 'react-bootstrap';
import { Link } from 'react-router-dom';
import { Button } from '@chakra-ui/react'


function Cards( { item } ) {


  return (
    <div className='cards'>
    <Container>
      <Link to={`/products/${item.id}`}>
        <Card style={{ width: '18rem' }}>
          <Card.Img className='cardimage' variant="top" src={item.image} />
            <Card.Body className='cardbody' >
            <Card.Title >{item.title}</Card.Title>
            <Card.Text>Fiyat: {item.price} TL</Card.Text>
          <Button colorScheme='teal'>Satın al</Button>
        </Card.Body>
      </Card>
      </Link>
    
    
    </Container>
    </div>
  );
}

export default Cards;

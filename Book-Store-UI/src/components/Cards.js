

import Card from 'react-bootstrap/Card';
import { Container } from 'react-bootstrap';
import { Link } from 'react-router-dom';
import { Button } from '@chakra-ui/react'


function Cards( { item } ) {
  // const authorName = item.author.authorName;

  return (
    <div className='cards'>

    <Container>
      <Link to={`/products/${item.id}`}>
        <Card style={{ width: '18rem' }}>
          <Card.Img className='cardimage' variant="top" src={item.imagePath} />
            <Card.Body className='cardbody' >
            <Card.Title >{item.bookTitle}</Card.Title>
            <Card.Text>Fiyat: {item.price} TL</Card.Text>
            <Card.Text>{item.publisher}</Card.Text>
            {/* <Card.Text>{authorName}</Card.Text> */}
          <Button colorScheme='teal'>Satın al</Button>
        </Card.Body>
      </Card>
      </Link>
    
    
    </Container>
    </div>
  );
}

export default Cards;

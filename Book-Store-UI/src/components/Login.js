import React, { useEffect ,useState } from "react";
import { Formik } from "formik";
import { Button } from "@chakra-ui/react";
import { register } from "../API";



const Login = () => (

 

  
    <div className="login-page">
      <h2>Giriş Yapınız</h2>
      <Formik
        initialValues={{username: '',email: '', password: ''}}
        validate={values => {
          const errors = {};
          if (!values.email) {
            errors.email = 'Zorunlu';
            
          } else if (
            !/^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$/i.test(values.email)
          ) {
            errors.email = 'Geçerli bir adres girin';
          }
          return errors;
        }}
         
        onSubmit={async (values,{ setSubmitting }) => {
          
            try {
              const registerPost = await register ({
                email:values.email,
                username:values.username,
                password:values.password
              });
              console.log(registerPost)
            } catch (error) {
              
            }
            setSubmitting(false);
           
          
        }}
        
      >
        {({
          values,
          errors,
          touched,
          handleChange,
          handleBlur,
          handleSubmit,
          isSubmitting,
         
          
        }) => (
          <form onSubmit={handleSubmit}>

            <div className="formEleman">Kullanıcı Adı</div>
           
           <div>{errors.email && touched.email && errors.email}</div> 
            
            
            <input type="text"
            name="username"
            onChange={handleChange}
            onBlur={handleBlur}
            value={values.username}
            
            />




            
            <div className="formEleman">E-posta Adresiniz</div>
            

            <input type="email"
              name="email"
              onChange={handleChange}
              onBlur={handleBlur}
              value={values.email}
              
            />
            
            

            <div className="formEleman">Şifre</div>
            <input
              type="password"
              name="password"
              onChange={handleChange}
              onBlur={handleBlur}
              value={values.password}
            />
            {errors.password && touched.password && errors.password}
            <br/><br/>
            <Button colorScheme='teal' type="submit" disabled={isSubmitting}>
              Üye Ol
            </Button>

          </form>
        )}
      </Formik>
    </div>
  );
  
  export default Login;
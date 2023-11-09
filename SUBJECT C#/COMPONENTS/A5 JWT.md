
### JWT
JWT stands for "JSON Web Token." It is a compact, URL-safe means of representing claims to be transferred between two parties. The claims in a JWT are typically used to identify a user, and can also carry additional data. JWTs are often used for authentication and authorization purposes in web applications and APIs.

Here's a brief overview of the key components of a JWT:

1. Header: The header typically consists of two parts: the type of token (JWT) and the signing algorithm being used, such as HMAC SHA256 or RSA.
2. Payload: The payload contains the claims. Claims are statements about an entity (typically, the user) and additional data. There are three types of claims: registered, public, and private claims. Some common registered claims are "iss" (issuer), "exp" (expiration time), and "sub" (subject). You can also include custom claims in the payload.
3. Signature: To create the signature part, you take the encoded header, the encoded payload, a secret or a public/private key pair, and the algorithm specified in the header, and then you sign that data.

- The typical use case for JWT is for an authentication mechanism. When a user logs in, a JWT is created on the server and then sent to the client. The client can store the JWT and include it in the headers of subsequent requests to access protected resources on the server. 
The server can then verify the JWT's signature and check the claims to authenticate the user and determine their access rights.
- JWTs are widely used for single sign-on (SSO) and as a means of securely transmitting information between parties in a stateless way. 
They are often used in conjunction with OAuth 2.0 and OpenID Connect for authentication and authorization in web applications.

It's important to note that JWTs are not encrypted; they are signed to ensure their integrity and authenticity. 
If sensitive data needs to be kept confidential, it should be encrypted separately.


### JWT CODE
```json
{
  "alg": "HS256",
  "typ": "JWT"
}

{
  "sub": "1234567890",     // Subject (user ID)
  "name": "John Doe",      // User's name
  "admin": true,           // Is the user an admin?
  "iat": 1613527842,        // Issued at (timestamp)
  "exp": 1613537842

}
```

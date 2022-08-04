# CDinner API

- [CDinner API](#)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)

## Auth

### Register

``` js
POST {{host}}/auth/register
```

#### Register Request

```json
{
    "fistName": "Edson",
    "lastName": "Canganjo",
    "email": "edsoncanganjo@dev.pt",
    "password": "EdsonPass"
}
```

#### Register Response

```js
200 OK
```

```json
{
  "id": "d89c9d5sd59ds-5ds51s-5ds4ds-5s65ds10",
  "fistName": "Edson",
  "lastName": "Canganjo",
  "email": "edsoncanganjo@dev.pt",
  "token": "ey65jks..d85dsFDs"
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
  "email": "edsoncanganjo@dev.pt",
  "password": "EdsonPass"
}
```

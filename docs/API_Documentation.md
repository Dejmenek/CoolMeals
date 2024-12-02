# 📝 CoolMeals API Documentation
**Base URL**: `http://localhost:5500`

---

## Table of Contents
* [User Management](#user-management)
* [Ingredients Management](#ingredients)
* [Dietary Preferences](#dietary-preferences)
* [Intolerances Management](#intolerances-management)
* [Recipes Management](#recipes-management)

### **User Management**

#### **Register User**
- **Endpoint**: `/api/v1/users/register`
- **Method**: `POST`

**Request Body**:
```json
  {
    "Username": "string",
    "Password": "string",
    "Email": "string"
  }
```

**Response Body**:
```json
  {
    "Message": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 400 | Bad Request |
| 409 | Conflict |

#### **Login User**
- **Endpoint**: `/api/v1/users/login`
- **Method**: `POST`

**Request Body**:
```json
  {
    "Username": "string",
    "Password": "string"
  }
```

**Response Body**:
```json
  {
    "Message": "string",
    "Token": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 401 | Unauthorized |

#### **Delete User Account**
- **Endpoint**: `/api/v1/users`
- **Method**: `DELETE`

**Request Header**:  
```
Authorization: Bearer <token>
```

**Response Body**:
```json
  {
    "Message": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 404 | Not Found |
| 401 | Unauthorized |

### **Ingredients Management**

#### **Add User Ingredients**

- **Endpoint**: `/api/v1/ingredients`
- **Method**: `POST`

**Request Header**:  
```
Authorization: Bearer <token>
```

**Request Body**:
```json
[
  {
    "Amount": "number",
    "UnitMeasurement": "string",
    "ExpiryDate": "string",
    "IngredientExternalApiId": "number"
  }
]
```

**Response Body**:
```json
  {
    "Message": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 400 | Bad Request |
| 401 | Unauthorized |

#### **Delete User Ingredients**
- **Endpoint**: `/api/v1/ingredients`
- **Method**: `DELETE`

**Request Header**:  
```
Authorization: Bearer <token>
```

**Request Body**:
```json
[
  {
    "IngredientId": "number"
  }
]
```

**Response Body**:
```json
  {
    "Message": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 404 | Not Found |
| 401 | Unauthorized |

#### **Get User Ingredients**

- **Endpoint**: `/api/v1/ingredients`
- **Method**: `GET`

**Request Header**:  
```
Authorization: Bearer <token>
```

**Response Body**:
```json
  {
    [
        {
            "IngredientId": "number",
            "Name": "string",
            "Amount": "number",
            "UnitMeasurement": "string",
            "ExpiryDate": "string",
        }
    ],
    "Message": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 401 | Unauthorized |

#### **Update User Ingredients**
- **Endpoint**: `/api/v1/ingredients`
- **Method**: `PUT`

**Request Header**:  
```
Authorization: Bearer <token>
```

**Request Body**:
```json
[
  {
    "IngredientId": "number",
    "Amount": "number"
  }
]
```

**Response Body**:
```json
  {
    "Message": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 404 | Not Found |
| 400 | Bad Request |
| 401 | Unauthorized |

### **Dietary Preferences**

#### **Add User Dietary Preferences**
- **Endpoint**: `/api/v1/diets`
- **Method**: `POST`

**Request Header**:  
```
Authorization: Bearer <token>
```

**Request Body**:
```json
[
  {
    "DietId": "number"
  }
]
```

**Response Body**:
```json
  {
    "Message": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 404 | Not Found |
| 401 | Unauthorized |

#### **Get User Dietary Preferences**
- **Endpoint**: `/api/v1/diets`
- **Method**: `GET`

**Request Header**:  
```
Authorization: Bearer <token>
```

**Response Body**:
```json
  {
    [
        {
            "DietId": "number",
            "Name": "string",
            "Description": "string"
        }
    ],
    "Message": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 401 | Unauthorized |

#### **Delete User Dietary Preferences**
- **Endpoint**: `/api/v1/diets`
- **Method**: `DELETE`

**Request Header**:  
```
Authorization: Bearer <token>
```

**Request Body**:
```json
[
  {
    "DietId": "number"
  }
]
```

**Response Body**:
```json
  {
    "Message": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 404 | Not Found |
| 401 | Unauthorized |

### **Intolerances Management**

#### **Add User Intolerances**
- **Endpoint**: `/api/v1/intolerances`
- **Method**: `POST`

**Request Header**:  
```
Authorization: Bearer <token>
```

**Request Body**:
```json
[
  {
    "IntoleranceId": "number"
  }
]
```

**Response Body**:
```json
  {
    "Message": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 404 | Not Found |
| 401 | Unauthorized |


#### **Get User Intolerances**
- **Endpoint**: `/api/v1/intolerances`
- **Method**: `GET`

**Request Header**:  
```
Authorization: Bearer <token>
```

**Response Body**:
```json
  {
    [
        {
            "IntoleranceId": "number",
            "Name": "string",
            "Description": "string"
        }
    ],
    "Message": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 401 | Unauthorized |

#### **Delete User Intolerances**
- **Endpoint**: `/api/v1/intolerances`
- **Method**: `DELETE`

**Request Header**:  
```
Authorization: Bearer <token>
```

**Request Body**:
```json
[
  {
    "IntoleranceId": "number"
  }
]
```

**Response Body**:
```json
  {
    "Message": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 404 | Not Found |
| 401 | Unauthorized |

### **Recipes Management**

#### **Add User Recipes**
- **Endpoint**: `/api/v1/recipes`
- **Method**: `POST`

**Request Header**:  
```
Authorization: Bearer <token>
```

**Request Body**:
```json
[
  {
    "RecipeApiId": "number"
  }
]
```

**Response Body**:
```json
  {
    "Message": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 404 | Not Found |
| 401 | Unauthorized |

#### **Delete User Recipes**
- **Endpoint**: `/api/v1/recipes`
- **Method**: `DELETE`

**Request Header**:  
```
Authorization: Bearer <token>
```

**Request Body**:
```json
[
  {
    "RecipeId": "number"
  }
]
```

**Response Body**:
```json
  {
    "Message": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 404 | Not Found |
| 401 | Unauthorized |

#### **Get Recipe Suggestions**
- **Endpoint**: `/api/v1/recipes/suggestions`
- **Method**: `GET`

**Request Header**:  
```
Authorization: Bearer <token>
```

**Response Body**:
```json
  {
     [
        {
            "RecipeId": "number",
            "Servings": "number
            "Title": "string",
            "Instructions": "string",
            "ReadyInMinutes": "number",
            "Ingredients": [
                {
                    "IngredientId": "number",
                    "Amount": "number",
                    "Name": "string",
                    "Original": "string",
                    "Measures": {
                        "Metric": {
                            "Amount": "number",
                            "UnitLong": "string",
                            "UnitShort": "string"
                        },
                        "Us": {
                            "Amount": "number",
                            "UnitLong": "string",
                            "UnitShort": "string"
                        }
                    }
                }
            ]
        }
    ],
    "Message": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 401 | Unauthorized |

#### **Get Similar Recipes**
- **Endpoint**: `/api/v1/recipes/similar/{id}`
- **Method**: `GET`

**Request Header**:  
```
Authorization: Bearer <token>
```

**Response Body**:
```json
  {
    [
        {
            "RecipeId": "number",
            "Servings": "number
            "Title": "string",
            "Instructions": "string",
            "ReadyInMinutes": "number",
            "Ingredients": [
                {
                    "IngredientId": "number",
                    "Amount": "number",
                    "Name": "string",
                    "Original": "string",
                    "Measures": {
                        "Metric": {
                            "Amount": "number",
                            "UnitLong": "string",
                            "UnitShort": "string"
                        },
                        "Us": {
                            "Amount": "number",
                            "UnitLong": "string",
                            "UnitShort": "string"
                        }
                    }
                }
            ]
        }
    ],
    "Message": "string"
  }
```
| Status Code | Message |
| --- | --- |
| 200 | OK |
| 401 | Unauthorized |
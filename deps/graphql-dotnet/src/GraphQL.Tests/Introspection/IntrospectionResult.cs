﻿namespace GraphQL.Tests.Introspection
{
    public class IntrospectionResult
    {
        public static readonly string Data = "{\r\n  \"__schema\": {\r\n    \"queryType\": null,\r\n    \"mutationType\": null,\r\n    \"subscriptionType\": null,\r\n    \"types\": [\r\n      {\r\n        \"kind\": \"SCALAR\",\r\n        \"name\": \"String\",\r\n        \"description\": null,\r\n        \"fields\": null,\r\n        \"inputFields\": null,\r\n        \"interfaces\": null,\r\n        \"enumValues\": null,\r\n        \"possibleTypes\": null\r\n      },\r\n      {\r\n        \"kind\": \"SCALAR\",\r\n        \"name\": \"Boolean\",\r\n        \"description\": null,\r\n        \"fields\": null,\r\n        \"inputFields\": null,\r\n        \"interfaces\": null,\r\n        \"enumValues\": null,\r\n        \"possibleTypes\": null\r\n      },\r\n      {\r\n        \"kind\": \"SCALAR\",\r\n        \"name\": \"Float\",\r\n        \"description\": null,\r\n        \"fields\": null,\r\n        \"inputFields\": null,\r\n        \"interfaces\": null,\r\n        \"enumValues\": null,\r\n        \"possibleTypes\": null\r\n      },\r\n      {\r\n        \"kind\": \"SCALAR\",\r\n        \"name\": \"Int\",\r\n        \"description\": null,\r\n        \"fields\": null,\r\n        \"inputFields\": null,\r\n        \"interfaces\": null,\r\n        \"enumValues\": null,\r\n        \"possibleTypes\": null\r\n      },\r\n      {\r\n        \"kind\": \"SCALAR\",\r\n        \"name\": \"ID\",\r\n        \"description\": null,\r\n        \"fields\": null,\r\n        \"inputFields\": null,\r\n        \"interfaces\": null,\r\n        \"enumValues\": null,\r\n        \"possibleTypes\": null\r\n      },\r\n      {\r\n        \"kind\": \"SCALAR\",\r\n        \"name\": \"Date\",\r\n        \"description\": \"The `Date` scalar type represents a timestamp provided in UTC. `Date` expects timestamps to be formatted in accordance with the [ISO-8601](https://en.wikipedia.org/wiki/ISO_8601) standard.\",\r\n        \"fields\": null,\r\n        \"inputFields\": null,\r\n        \"interfaces\": null,\r\n        \"enumValues\": null,\r\n        \"possibleTypes\": null\r\n      },\r\n      {\r\n        \"kind\": \"SCALAR\",\r\n        \"name\": \"Decimal\",\r\n        \"description\": null,\r\n        \"fields\": null,\r\n        \"inputFields\": null,\r\n        \"interfaces\": null,\r\n        \"enumValues\": null,\r\n        \"possibleTypes\": null\r\n      },\r\n      {\r\n        \"kind\": \"OBJECT\",\r\n        \"name\": \"__Schema\",\r\n        \"description\": \"A GraphQL Schema defines the capabilities of a GraphQL server. It exposes all available types and directives on the server, as well as the entry points for query, mutation, and subscription operations.\",\r\n        \"fields\": [\r\n          {\r\n            \"name\": \"types\",\r\n            \"description\": \"A list of all types supported by this server.\",\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"LIST\",\r\n                \"name\": null,\r\n                \"ofType\": {\r\n                  \"kind\": \"NON_NULL\",\r\n                  \"name\": null,\r\n                  \"ofType\": {\r\n                    \"kind\": \"OBJECT\",\r\n                    \"name\": \"__Type\",\r\n                    \"ofType\": null\r\n                  }\r\n                }\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"queryType\",\r\n            \"description\": \"The type that query operations will be rooted at.\",\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"OBJECT\",\r\n                \"name\": \"__Type\",\r\n                \"ofType\": null\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"mutationType\",\r\n            \"description\": \"If this server supports mutation, the type that mutation operations will be rooted at.\",\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"OBJECT\",\r\n              \"name\": \"__Type\",\r\n              \"ofType\": null\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"subscriptionType\",\r\n            \"description\": \"If this server supports subscription, the type that subscription operations will be rooted at.\",\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"OBJECT\",\r\n              \"name\": \"__Type\",\r\n              \"ofType\": null\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"directives\",\r\n            \"description\": \"A list of all directives supported by this server.\",\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"LIST\",\r\n                \"name\": null,\r\n                \"ofType\": {\r\n                  \"kind\": \"NON_NULL\",\r\n                  \"name\": null,\r\n                  \"ofType\": {\r\n                    \"kind\": \"OBJECT\",\r\n                    \"name\": \"__Directive\",\r\n                    \"ofType\": null\r\n                  }\r\n                }\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          }\r\n        ],\r\n        \"inputFields\": null,\r\n        \"interfaces\": [],\r\n        \"enumValues\": null,\r\n        \"possibleTypes\": null\r\n      },\r\n      {\r\n        \"kind\": \"OBJECT\",\r\n        \"name\": \"__Type\",\r\n        \"description\": \"The fundamental unit of any GraphQL Schema is the type. There are many kinds of types in GraphQL as represented by the `__TypeKind` enum.\\r\\n\\r\\nDepending on the kind of a type, certain fields describe information about that type. Scalar types provide no information beyond a name and description, while Enum types provide their values. Object and Interface types provide the fields they describe. Abstract types, Union and Interface, provide the Object types possible at runtime. List and NonNull types compose other types.\",\r\n        \"fields\": [\r\n          {\r\n            \"name\": \"kind\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"ENUM\",\r\n                \"name\": \"__TypeKind\",\r\n                \"ofType\": null\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"name\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"SCALAR\",\r\n              \"name\": \"String\",\r\n              \"ofType\": null\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"description\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"SCALAR\",\r\n              \"name\": \"String\",\r\n              \"ofType\": null\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"fields\",\r\n            \"description\": null,\r\n            \"args\": [\r\n              {\r\n                \"name\": \"includeDeprecated\",\r\n                \"description\": null,\r\n                \"type\": {\r\n                  \"kind\": \"SCALAR\",\r\n                  \"name\": \"Boolean\",\r\n                  \"ofType\": null\r\n                },\r\n                \"defaultValue\": \"false\"\r\n              }\r\n            ],\r\n            \"type\": {\r\n              \"kind\": \"LIST\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"NON_NULL\",\r\n                \"name\": null,\r\n                \"ofType\": {\r\n                  \"kind\": \"OBJECT\",\r\n                  \"name\": \"__Field\",\r\n                  \"ofType\": null\r\n                }\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"interfaces\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"LIST\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"NON_NULL\",\r\n                \"name\": null,\r\n                \"ofType\": {\r\n                  \"kind\": \"OBJECT\",\r\n                  \"name\": \"__Type\",\r\n                  \"ofType\": null\r\n                }\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"possibleTypes\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"LIST\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"NON_NULL\",\r\n                \"name\": null,\r\n                \"ofType\": {\r\n                  \"kind\": \"OBJECT\",\r\n                  \"name\": \"__Type\",\r\n                  \"ofType\": null\r\n                }\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"enumValues\",\r\n            \"description\": null,\r\n            \"args\": [\r\n              {\r\n                \"name\": \"includeDeprecated\",\r\n                \"description\": null,\r\n                \"type\": {\r\n                  \"kind\": \"SCALAR\",\r\n                  \"name\": \"Boolean\",\r\n                  \"ofType\": null\r\n                },\r\n                \"defaultValue\": \"false\"\r\n              }\r\n            ],\r\n            \"type\": {\r\n              \"kind\": \"LIST\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"NON_NULL\",\r\n                \"name\": null,\r\n                \"ofType\": {\r\n                  \"kind\": \"OBJECT\",\r\n                  \"name\": \"__EnumValue\",\r\n                  \"ofType\": null\r\n                }\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"inputFields\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"LIST\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"NON_NULL\",\r\n                \"name\": null,\r\n                \"ofType\": {\r\n                  \"kind\": \"OBJECT\",\r\n                  \"name\": \"__InputValue\",\r\n                  \"ofType\": null\r\n                }\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"ofType\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"OBJECT\",\r\n              \"name\": \"__Type\",\r\n              \"ofType\": null\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          }\r\n        ],\r\n        \"inputFields\": null,\r\n        \"interfaces\": [],\r\n        \"enumValues\": null,\r\n        \"possibleTypes\": null\r\n      },\r\n      {\r\n        \"kind\": \"ENUM\",\r\n        \"name\": \"__TypeKind\",\r\n        \"description\": \"An enum describing what kind of type a given __Type is.\",\r\n        \"fields\": null,\r\n        \"inputFields\": null,\r\n        \"interfaces\": null,\r\n        \"enumValues\": [\r\n          {\r\n            \"name\": \"SCALAR\",\r\n            \"description\": \"Indicates this type is a scalar.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"OBJECT\",\r\n            \"description\": \"Indicates this type is an object.  `fields` and `possibletypes` are valid fields.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"INTERFACE\",\r\n            \"description\": \"Indicates this type is an interface.  `fields` and `possibleTypes` are valid fields.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"UNION\",\r\n            \"description\": \"Indicates this type is a union.  `possibleTypes` is a valid field.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"ENUM\",\r\n            \"description\": \"Indicates this type is an num.  `enumValues` is a valid field.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"INPUT_OBJECT\",\r\n            \"description\": \"Indicates this type is an input object.  `inputFields` is a valid field.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"LIST\",\r\n            \"description\": \"Indicates this type is a list.  `ofType` is a valid field.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"NON_NULL\",\r\n            \"description\": \"Indicates this type is a non-null.  `ofType` is a valid field.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          }\r\n        ],\r\n        \"possibleTypes\": null\r\n      },\r\n      {\r\n        \"kind\": \"OBJECT\",\r\n        \"name\": \"__Field\",\r\n        \"description\": \"Object and Interface types are described by a list of Fields, each of which has a name, potentially a list of arguments, and a return type.\",\r\n        \"fields\": [\r\n          {\r\n            \"name\": \"name\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"SCALAR\",\r\n                \"name\": \"String\",\r\n                \"ofType\": null\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"description\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"SCALAR\",\r\n              \"name\": \"String\",\r\n              \"ofType\": null\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"args\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"LIST\",\r\n                \"name\": null,\r\n                \"ofType\": {\r\n                  \"kind\": \"NON_NULL\",\r\n                  \"name\": null,\r\n                  \"ofType\": {\r\n                    \"kind\": \"OBJECT\",\r\n                    \"name\": \"__InputValue\",\r\n                    \"ofType\": null\r\n                  }\r\n                }\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"type\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"OBJECT\",\r\n                \"name\": \"__Type\",\r\n                \"ofType\": null\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"isDeprecated\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"SCALAR\",\r\n                \"name\": \"Boolean\",\r\n                \"ofType\": null\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"deprecationReason\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"SCALAR\",\r\n              \"name\": \"String\",\r\n              \"ofType\": null\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          }\r\n        ],\r\n        \"inputFields\": null,\r\n        \"interfaces\": [],\r\n        \"enumValues\": null,\r\n        \"possibleTypes\": null\r\n      },\r\n      {\r\n        \"kind\": \"OBJECT\",\r\n        \"name\": \"__InputValue\",\r\n        \"description\": \"Arguments provided to Fields or Directives and the input fields of an InputObject are represented as Input Values which describe their type and optionally a default value.\",\r\n        \"fields\": [\r\n          {\r\n            \"name\": \"name\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"SCALAR\",\r\n                \"name\": \"String\",\r\n                \"ofType\": null\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"description\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"SCALAR\",\r\n              \"name\": \"String\",\r\n              \"ofType\": null\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"type\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"OBJECT\",\r\n                \"name\": \"__Type\",\r\n                \"ofType\": null\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"defaultValue\",\r\n            \"description\": \"A GraphQL-formatted string representing the default value for this input value.\",\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"SCALAR\",\r\n              \"name\": \"String\",\r\n              \"ofType\": null\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          }\r\n        ],\r\n        \"inputFields\": null,\r\n        \"interfaces\": [],\r\n        \"enumValues\": null,\r\n        \"possibleTypes\": null\r\n      },\r\n      {\r\n        \"kind\": \"OBJECT\",\r\n        \"name\": \"__EnumValue\",\r\n        \"description\": \"One possible value for a given Enum. Enum values are unique values, not a placeholder for a string or numeric value. However an Enum value is returned in a JSON response as a string.\",\r\n        \"fields\": [\r\n          {\r\n            \"name\": \"name\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"SCALAR\",\r\n                \"name\": \"String\",\r\n                \"ofType\": null\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"description\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"SCALAR\",\r\n              \"name\": \"String\",\r\n              \"ofType\": null\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"isDeprecated\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"SCALAR\",\r\n                \"name\": \"String\",\r\n                \"ofType\": null\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"deprecationReason\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"SCALAR\",\r\n              \"name\": \"String\",\r\n              \"ofType\": null\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          }\r\n        ],\r\n        \"inputFields\": null,\r\n        \"interfaces\": [],\r\n        \"enumValues\": null,\r\n        \"possibleTypes\": null\r\n      },\r\n      {\r\n        \"kind\": \"OBJECT\",\r\n        \"name\": \"__Directive\",\r\n        \"description\": \"A Directive provides a way to describe alternate runtime execution and type validation behavior in a GraphQL document.\\r\\n\\r\\nIn some cases, you need to provide options to alter GraphQL's execution behavior in ways field arguments will not suffice, such as conditionally including or skipping a field. Directives provide this by describing additional information to the executor.\",\r\n        \"fields\": [\r\n          {\r\n            \"name\": \"name\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"SCALAR\",\r\n                \"name\": \"String\",\r\n                \"ofType\": null\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"description\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"SCALAR\",\r\n              \"name\": \"String\",\r\n              \"ofType\": null\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"locations\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"LIST\",\r\n                \"name\": null,\r\n                \"ofType\": {\r\n                  \"kind\": \"NON_NULL\",\r\n                  \"name\": null,\r\n                  \"ofType\": {\r\n                    \"kind\": \"ENUM\",\r\n                    \"name\": \"__DirectiveLocation\",\r\n                    \"ofType\": null\r\n                  }\r\n                }\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"args\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"LIST\",\r\n                \"name\": null,\r\n                \"ofType\": {\r\n                  \"kind\": \"NON_NULL\",\r\n                  \"name\": null,\r\n                  \"ofType\": {\r\n                    \"kind\": \"OBJECT\",\r\n                    \"name\": \"__InputValue\",\r\n                    \"ofType\": null\r\n                  }\r\n                }\r\n              }\r\n            },\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"onOperation\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"SCALAR\",\r\n                \"name\": \"Boolean\",\r\n                \"ofType\": null\r\n              }\r\n            },\r\n            \"isDeprecated\": true,\r\n            \"deprecationReason\": \"Use 'locations'.\"\r\n          },\r\n          {\r\n            \"name\": \"onFragment\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"SCALAR\",\r\n                \"name\": \"Boolean\",\r\n                \"ofType\": null\r\n              }\r\n            },\r\n            \"isDeprecated\": true,\r\n            \"deprecationReason\": \"Use 'locations'.\"\r\n          },\r\n          {\r\n            \"name\": \"onField\",\r\n            \"description\": null,\r\n            \"args\": [],\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"SCALAR\",\r\n                \"name\": \"Boolean\",\r\n                \"ofType\": null\r\n              }\r\n            },\r\n            \"isDeprecated\": true,\r\n            \"deprecationReason\": \"Use 'locations'.\"\r\n          }\r\n        ],\r\n        \"inputFields\": null,\r\n        \"interfaces\": [],\r\n        \"enumValues\": null,\r\n        \"possibleTypes\": null\r\n      },\r\n      {\r\n        \"kind\": \"ENUM\",\r\n        \"name\": \"__DirectiveLocation\",\r\n        \"description\": \"A Directive can be adjacent to many parts of the GraphQL language, a __DirectiveLocation describes one such possible adjacencies.\",\r\n        \"fields\": null,\r\n        \"inputFields\": null,\r\n        \"interfaces\": null,\r\n        \"enumValues\": [\r\n          {\r\n            \"name\": \"QUERY\",\r\n            \"description\": \"Location adjacent to a query operation.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"MUTATION\",\r\n            \"description\": \"Location adjacent to a mutation operation.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"SUBSCRIPTION\",\r\n            \"description\": \"Location adjacent to a subscription operation.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"FIELD\",\r\n            \"description\": \"Location ajdacent to a field.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"FRAGMENT_DEFINITION\",\r\n            \"description\": \"Location adjacent to a fragment definition.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"FRAGMENT_SPREAD\",\r\n            \"description\": \"Location adjacent to a fragment spread.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"INLINE_FRAGMENT\",\r\n            \"description\": \"Location adjacent to an inline fragment.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"SCHEMA\",\r\n            \"description\": \"Location adjacent to a schema definition.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"SCALAR\",\r\n            \"description\": \"Location adjacent to a scalar definition.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"OBJECT\",\r\n            \"description\": \"Location adjacent to an object type definition.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"FIELD_DEFINITION\",\r\n            \"description\": \"Location adjacent to a field definition.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"ARGUMENT_DEFINITION\",\r\n            \"description\": \"Location adjacent to an argument defintion.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"INTERFACE\",\r\n            \"description\": \"Location adjacent to an interface definition.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"UNION\",\r\n            \"description\": \"Location adjacent to a union definition.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"ENUM\",\r\n            \"description\": \"Location adjacent to an enum definition\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"ENUM_VALUE\",\r\n            \"description\": \"Location adjacent to an enum value definition\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"INPUT_OBJECT\",\r\n            \"description\": \"Location adjacent to an input object type defintion.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          },\r\n          {\r\n            \"name\": \"INPUT_FIELD_DEFINITION\",\r\n            \"description\": \"Location adjacent to an input object field definition.\",\r\n            \"isDeprecated\": false,\r\n            \"deprecationReason\": null\r\n          }\r\n        ],\r\n        \"possibleTypes\": null\r\n      }\r\n    ],\r\n    \"directives\": [\r\n      {\r\n        \"name\": \"include\",\r\n        \"description\": \"Directs the executor to include this field or fragment only when the 'if' argument is true.\",\r\n        \"locations\": [\r\n          \"FIELD\",\r\n          \"FRAGMENT_SPREAD\",\r\n          \"INLINE_FRAGMENT\"\r\n        ],\r\n        \"args\": [\r\n          {\r\n            \"name\": \"if\",\r\n            \"description\": \"Included when true.\",\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"SCALAR\",\r\n                \"name\": \"Boolean\",\r\n                \"ofType\": null\r\n              }\r\n            },\r\n            \"defaultValue\": \"null\"\r\n          }\r\n        ]\r\n      },\r\n      {\r\n        \"name\": \"skip\",\r\n        \"description\": \"Directs the executor to skip this field or fragment when the 'if' argument is true.\",\r\n        \"locations\": [\r\n          \"FIELD\",\r\n          \"FRAGMENT_SPREAD\",\r\n          \"INLINE_FRAGMENT\"\r\n        ],\r\n        \"args\": [\r\n          {\r\n            \"name\": \"if\",\r\n            \"description\": \"Skipped when true.\",\r\n            \"type\": {\r\n              \"kind\": \"NON_NULL\",\r\n              \"name\": null,\r\n              \"ofType\": {\r\n                \"kind\": \"SCALAR\",\r\n                \"name\": \"Boolean\",\r\n                \"ofType\": null\r\n              }\r\n            },\r\n            \"defaultValue\": \"null\"\r\n          }\r\n        ]\r\n      },\r\n      {\r\n        \"name\": \"deprecated\",\r\n        \"description\": \"Marks an element of a GraphQL schema as no longer supported.\",\r\n        \"locations\": [\r\n          \"FIELD_DEFINITION\",\r\n          \"ENUM_VALUE\"\r\n        ],\r\n        \"args\": [\r\n          {\r\n            \"name\": \"reason\",\r\n            \"description\": \"Explains why this element was deprecated, usually also including a suggestion for how to access supported similar data. Formatted in [Markdown](https://daringfireball.net/projects/markdown/).\",\r\n            \"type\": {\r\n              \"kind\": \"SCALAR\",\r\n              \"name\": \"String\",\r\n              \"ofType\": null\r\n            },\r\n            \"defaultValue\": \"\\\"No longer supported\\\"\"\r\n          }\r\n        ]\r\n      }\r\n    ]\r\n  }\r\n}";
    }
}

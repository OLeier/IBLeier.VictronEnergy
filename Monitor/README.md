#  - VRM Monitor

## VRM API

https://vrm-api-docs.victronenergy.com/#/  
incl. Export Möglichkeit für document.yaml

## Open API

Install globally, exposing the CLI on the command line:

### install the latest version of "openapi-generator-cli"
npm install @openapitools/openapi-generator-cli -g

### use a specific version of "openapi-generator-cli"
openapi-generator-cli version-manager set 6.2.0

### Or install it as dev-dependency in your node.js projects
npm install @openapitools/openapi-generator-cli -D

Then, generate a ruby client from a valid petstore.yaml doc:

openapi-generator-cli generate -i petstore.yaml -g ruby -o /tmp/test/

openapi-generator-cli help
openapi-generator-cli validate -i api_v1.yaml
openapi-generator-cli generate -i VrmApi_BundledReferences.yaml -g csharp --skip-validate-spec
openapi-generator-cli generate -i OpenAPI.json -g csharp

## json -> swagger
https://swagger-toolbox.firebaseapp.com/ - Swagger toolbox
- uses number -> double
- with required

https://roger13.github.io/SwagDefGen/ - Swagger Definition Objects Generator
- uses integer + int32 -> int
- w/o required

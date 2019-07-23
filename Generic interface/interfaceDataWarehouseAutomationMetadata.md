# Interface specification - Data Warehouse Automation Metadata

This is a work-in-progress section to define the target format. Just started / in development, focusing on the schema definition first and back-filling documentation after.

The schema is and examples are validated / extended using <https://www.jsonschemavalidator.net/> or https://jsonschemalint.com/. 

Standards are followed from http://json-schema.org/.  Also see http://json-schema.org/learn/miscellaneous-examples.html.

**Critical things too do for even a version 1**

- Make sure business keys are created in collections, to support concatenation and composition.

## Requirements:

- Needs to be able to generate source and target structures (DDL).
- Needs to be able to generate transformation logic using and externally applied template based on metadata available in the Json.
- Needs to encompass all known Data Vault use-cases (see checklist for Data Vault conformance) in a single object.

## **Schema**

The proposed Json schema has standard components for table and column structures that are reused for sources and targets. At the mapping level only the classification, filter and load direction are added, the rest is generic reuse of definitions.

At a high level the schema consists of Data Object Mappings (mappings between Data Objects). 

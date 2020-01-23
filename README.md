# dp-metadata

Object model for standardising the structure of metadata used to describe the processes within a data pipelines.
The intention is to enable loose coupling between tools or components. Allowing for the construction of pipelines using compliant tools, without lock-in to a specific tool set.
The canonical model is provided as a JSON Schema.

The intention is not to define a standard toolset. Rather to define a standard schema for the metadata which serves as input to a variety of  tools that can be used for building and running data pipelines. This standardisation is expected to enable better interoperability between disparate tools, whilst also assisting in preventing vendor lock-in.

Also under development. Checkout the [Data Processing Metadata Library (DPMLib)](https://github.com/scott-diprose/DPMLib.net). Which provides a core set of functionality to enable quickly intergrating metadata into your own pipelines.

---

The next revision will be looking at separating the intent from implementation. Where will be looking at adding an additional templating library to generate any specific implementation code from the captured intent. 

Comming up: 
- An additional library and CLI which applys Handlebars templates based on the DPMLib to produce specific implementations of a pipeline.
- Example pipelines for various technologies.

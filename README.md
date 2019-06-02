# dp-metadata

Metadata to describes processes within a data pipeline.

The canonical model is provided as a JSON Schema.

## WIP

At the moment only the schema for mapping data between data models/stores has been added, and so is marked as mandatory in the root schema. As other useful metadata is identified and modelled. Then this will not continue to be the case, and the root schema will only hold optional objects as root elements for each type.


The intention is not to define a standard toolset. Rather define a standard schema for the data which serves as input to a variety of  tools that can be used for data pipelines. This standardisation should enable better interoperability between disparate tools, and assist in preventing vendor lock-in.


At the moment specific extension points have been set for inclusion of additional data beyond the core schema. This is intended to promote clarity in identifying which data belongs to what extension.


Individual work can begin as an extension. Then once fleshed out with working examples, can be discussed as to it inclusion, or part thereof, into the core schema.


﻿drop table if exists Ottawa cascade;
create table Ottawa
(
	Object_ID serial primary key,
	PIN float not null,
	RoadName text not null,
	RoadType text not null
);

comment on table Ottawa is 'The adresses of Ottawa';
comment on column Ottawa.Object_ID is 'autogenerated ID.';
comment on column Ottawa.PIN is 'The PIN of the Object.';
comment on column Ottawa.RoadName is 'The the name of the road';
comment on column Ottawa.RoadType is 'The type of the road';


drop table if exists Ottawa_indexed cascade;
create table Ottawa_indexed
(
	Object_ID serial primary key,
	PIN float not null,
	RoadName text not null,
	RoadType text not null
);

comment on table Ottawa_indexed is 'The adresses of Ottawa';
comment on column Ottawa_indexed.Object_ID is 'autogenerated ID.';
comment on column Ottawa_indexed.PIN is 'The PIN of the Object.';
comment on column Ottawa_indexed.RoadName is 'The the name of the road';
comment on column Ottawa_indexed.RoadType is 'The type of the road';


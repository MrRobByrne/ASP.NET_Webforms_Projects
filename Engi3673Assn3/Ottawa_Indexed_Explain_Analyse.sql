--create index Road_Type
--on ottawa_indexed (roadtype);

--explain analyse select * from ottawa_indexed where roadtype='AVE';

--create index PIN
--on ottawa_indexed (pin);

--explain analyse select * from ottawa_indexed where pin > 40000000;

--create index Road_Name
--on ottawa_indexed (roadname);

explain analyse select * from ottawa_indexed
where roadtype='AVE' 
and pin > 40000000
and roadname='WOODMOUNT';
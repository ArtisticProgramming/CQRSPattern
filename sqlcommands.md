```sql
----------------------------------------Add Primery key------------------------------------------
ALTER TABLE dbo.table1
ADD PRIMARY KEY (Id)
-------------------------------------------Add column----------------------------------------------
ALTER TABLE dbo.table1
add  col1 DATETIME not null
-------------------------------------------Drop Coulumn--------------------------------------------
ALTER TABLE dbo.table1 DROP COLUMN col1
-----------------------------------------Delete Constraint-----------------------------------------
ALTER TABLE dbo.table1
DROP CONSTRAINT FK_tb1_tb2;   
---------------------------------------------Drop Table--------------------------------------------
DROP TABLE dbo.table1
---------------------------------------------change coulum type--------------------------------------------
ALTER TABLE dbo.table1
ALTER COLUMN column_1 datatype;
-----------------------------------Create Forign Key And Relation----------------------------------
ALTER TABLE dbo.X     
ADD CONSTRAINT FK_X_Y FOREIGN KEY (XID)     
REFERENCES dbo.Y (Id)
-----------------------------------Delete Forign Key And Relation----------------------------------
ALTER TABLE dbo.DocExe   
DROP CONSTRAINT FK_Column_B; 
```

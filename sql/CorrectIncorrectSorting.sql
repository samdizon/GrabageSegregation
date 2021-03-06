/****** Script for SelectTopNRows command from SSMS  ******/
SELECT Count(WasteSorting.Result) as Result, SortingCategories.Name
FROM WasteSorting INNER JOIN SortingCategories ON WasteSorting.SortingCategoryID = SortingCategories.ID
GROUP BY SortingCategories.Name, WasteSorting.Result
HAVING (((WasteSorting.Result)=1));

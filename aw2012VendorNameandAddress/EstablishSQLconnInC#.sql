 


ALTER PROC vendorNameandAddress
AS
	BEGIN
			SELECT A.AddressLine1, A.AddressLine2, SP.Name [State],A.City, A.PostalCode [Postal Code], PV.PreferredVendorStatus 
			FROM Purchasing.Vendor PV
			INNER JOIN  Person.BusinessEntity BE
			ON PV.BusinessEntityID = BE.BusinessEntityID
			INNER JOIN Person.BusinessEntityAddress BEA
			ON BEA.BusinessEntityID = BE.BusinessEntityID
			INNER JOIN Person.[Address] A
			ON BEA.AddressID = A.AddressID
			INNER JOIN Person.StateProvince SP
			ON A.StateProvinceID = SP.StateProvinceID
			WHERE PV.BusinessEntityID IS NOT NULL
	END
GO[dbo].[vendorNameandAddress]



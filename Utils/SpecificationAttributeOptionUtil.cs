﻿using InsertProductsFromExcelFiles.AppModels;
using InsertProductsFromExcelFiles.BiggBrands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InsertProductsFromExcelFiles.Utils
{
    public static class SpecificationAttributeOptionUtil
    {
        public static List<SpecificationAttribute> specificationAttributes;
        public static List<SpecificationAttributeOption> specificationAttributeOptions;
        public static string specificationAttributePrefix;

        

        public static SpecificationAttributeOptionCustomValueMap FindSpecificationAttributeOptionWithCustomValue(string specificationAttributeName,string specificationAttributeOptionName)
        {

            SpecificationAttribute specificationAttribute = specificationAttributes
                .Where(sa => sa.Name == specificationAttributeName).FirstOrDefault();

            SpecificationAttributeOptionCustomValueMap specificationAttributeOptionCustomValueMap = null;

            if (!string.IsNullOrEmpty(specificationAttributeOptionName)) { 
                if (specificationAttribute.DisplayOrder == 0)
                {
                    SpecificationAttributeOption specificationAttributeOption = specificationAttributeOptions
                    .Where(sao => sao.SpecificationAttributeId == specificationAttribute.Id && sao.Name == specificationAttributeName).FirstOrDefault();
                    if (specificationAttributeOption == null)
                    {
                        specificationAttributeOption = new SpecificationAttributeOption()
                        {
                            Name = specificationAttributeName ?? "",
                            SpecificationAttributeId = specificationAttribute.Id,
                            DisplayOrder = 0
                        };
                        specificationAttributeOptions.Add(specificationAttributeOption);
                        
                    }
                    specificationAttributeOptionCustomValueMap = new SpecificationAttributeOptionCustomValueMap()
                    {
                        specificationAttributeOption = specificationAttributeOption,
                        specificationAttributeOptionCustomValue = specificationAttributeOptionName
                    };

                }
                else
                {

                    SpecificationAttributeOption specificationAttributeOption = specificationAttributeOptions
                        .Where(sao => sao.SpecificationAttributeId == specificationAttribute.Id && sao.Name == specificationAttributeOptionName).FirstOrDefault();
                    if (specificationAttributeOption == null)
                    {
                        specificationAttributeOption = new SpecificationAttributeOption()
                        {
                            Name = specificationAttributeOptionName ?? "",
                            SpecificationAttributeId = specificationAttribute.Id,
                            DisplayOrder = 0
                        };
                        specificationAttributeOptions.Add(specificationAttributeOption);
                    }
                    specificationAttributeOptionCustomValueMap = new SpecificationAttributeOptionCustomValueMap()
                    {
                        specificationAttributeOption = specificationAttributeOption,
                        specificationAttributeOptionCustomValue = null
                    };
                }
            }


            return specificationAttributeOptionCustomValueMap;
        }
    }
}

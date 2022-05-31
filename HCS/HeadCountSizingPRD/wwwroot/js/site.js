// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




//ctx = {
//    attributeStyleID: (dataStyle == 'Currency' || dataStyle == 'Date') ? ' ss:StyleID="' + dataStyle + '"' : ''
//    , nameType: (dataType == 'Number' || dataType == 'DateTime' || dataType == 'Boolean' || dataType == 'Error') ? dataType : 'String'
//    , data: (dataFormula) ? '' : dataValue
//    , attributeFormula: (dataFormula) ? ' ss:Formula="' + dataFormula + '"' : ''
//};
//console.log(dataValue);
if (dataValue.includes("<input")) {
    //ctx = {
    //    attributeStyleID: (dataStyle == 'Currency' || dataStyle == 'Date') ? ' ss:StyleID="' + dataStyle + '"' : ''
    //    , nameType: (dataType == 'Number' || dataType == 'DateTime' || dataType == 'Boolean' || dataType == 'Error') ? dataType : 'String'
    //    , data: (dataFormula) ? '' : ''
    //    , attributeFormula: (dataFormula) ? ' ss:Formula="' + dataFormula + '"' : ''
    //};
}
else {
    if (dataValue.includes("<a")) {
        //ctx = {
        //    attributeStyleID: (dataStyle == 'Currency' || dataStyle == 'Date') ? ' ss:StyleID="' + dataStyle + '"' : ''
        //    , nameType: (dataType == 'Number' || dataType == 'DateTime' || dataType == 'Boolean' || dataType == 'Error') ? dataType : 'String'
        //    , data: (dataFormula) ? '' : ''
        //    , attributeFormula: (dataFormula) ? ' ss:Formula="' + dataFormula + '"' : ''
        //};
    }
    else {
        if (dataValue.includes("<select")) {
            //ctx = {
            //    attributeStyleID: (dataStyle == 'Currency' || dataStyle == 'Date') ? ' ss:StyleID="' + dataStyle + '"' : ''
            //    , nameType: (dataType == 'Number' || dataType == 'DateTime' || dataType == 'Boolean' || dataType == 'Error') ? dataType : 'String'
            //    , data: (dataFormula) ? '' : ''
            //    , attributeFormula: (dataFormula) ? ' ss:Formula="' + dataFormula + '"' : ''
            //};
        }
        else {
            if (dataValue.includes("<button")) {
                //ctx = {
                //    attributeStyleID: (dataStyle == 'Currency' || dataStyle == 'Date') ? ' ss:StyleID="' + dataStyle + '"' : ''
                //    , nameType: (dataType == 'Number' || dataType == 'DateTime' || dataType == 'Boolean' || dataType == 'Error') ? dataType : 'String'
                //    , data: (dataFormula) ? '' : ''
                //    , attributeFormula: (dataFormula) ? ' ss:Formula="' + dataFormula + '"' : ''
                //};
            }
            else {
                ctx = {
                    attributeStyleID: (dataStyle == 'Currency' || dataStyle == 'Date') ? ' ss:StyleID="' + dataStyle + '"' : ''
                    , nameType: (dataType == 'Number' || dataType == 'DateTime' || dataType == 'Boolean' || dataType == 'Error') ? dataType : 'String'
                    , data: (dataFormula) ? '' : dataValue
                    , attributeFormula: (dataFormula) ? ' ss:Formula="' + dataFormula + '"' : ''
                };
                rowsXML += format(tmplCellXML, ctx);
            }
        }
    }
}

                    //rowsXML += format(tmplCellXML, ctx);
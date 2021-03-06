﻿(function () {
    'use strict';

    angular
        .module('app')
        .factory('excel_factory', [function () {
            var scope = {
                $uri: 'data:application/vnd.ms-excel;base64,',
                $template: "<html xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:x=\"urn:schemas-microsoft-com:office:excel\" xmlns=\"http://www.w3.org/TR/REC-html40\">"+
                        "<head>"+
                        "<!--[if gte mso 9]>"+
                        "<xml>"+
                            "<x:ExcelWorkbook>"+
                                "<x:ExcelWorksheets>"+
                                    "<x:ExcelWorksheet>"+
                                        "<x:Name>{worksheet}</x:Name>"+
                                        "<x:WorksheetOptions>"+
                                            "<x:DisplayGridlines/>"+
                                        "</x:WorksheetOptions>"+
                                    "</x:ExcelWorksheet>"+
                                "</x:ExcelWorksheets>"+
                            "</x:ExcelWorkbook>"+
                        "</xml>"+
                        "<![endif]-->"+
                    "</head>"+
                    "<body>"+
                        "<table>{table}</table>"+
                    "</body>"+
                "</html>",
                $base64: $base64,
                $format: $format,
                Export: Export 
            };

            function $base64(s) { return window.btoa(unescape(encodeURIComponent(s))) };
            function $format(s, c) { return s.replace(/{(\w+)}/g, function (m, p) { return c[p]; }) };
            function Export(table, name) {
                if (!table.nodeType)
                    table = document.getElementById(table)
                var ctx = { worksheet: name || 'Worksheet', table: table.innerHTML }
                window.location.href = scope.$uri + scope.$base64(scope.$format(scope.$template, ctx))
            };
            return scope;
        }]);
})();
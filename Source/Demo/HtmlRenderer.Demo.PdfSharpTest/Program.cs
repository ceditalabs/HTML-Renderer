using System;
using System.IO;

namespace HtmlRenderer.Demo.PdfSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ms = File.Create("test.pdf"))
            {
                var html = @"<!doctype html>
<html>
<head>
    <title>Payslip for </title>
    <style type=""text/css"">
        <!--

        body {
            color: #000000;
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            margin: 0;
            padding: 0 20px;
        }

        .box {
            background-color: #8DCEEF;
            border: 1px solid #009ADA;
            margin-bottom: 10px;
            padding: 5px 10px;
        }

        .no-margin-b {
            margin-bottom: 0;
        }

        .no-fill {
            background-color: #FFFFFF;
        }

        .no-padding {
            padding: 0;
        }

        .round-tl, .round {
            border-top-left-radius: 5px;
        }

        .round-tr, .round {
            border-top-right-radius: 5px;
        }

        .round-bl, .round {
            border-bottom-left-radius: 5px;
        }

        .round-br, .round {
            border-bottom-right-radius: 5px;
        }

        .float-left {
            float: left;
        }


        .details-panel p {
            margin: 0 0 5px;
            padding: 0 5px;
        }

        .text-left {
            text-align: left;
        }

        .text-center {
            text-align: center;
        }

        .text-right {
            text-align: right;
        }

        .clear {
            clear: both;
        }

        .full-width {
            width: 100%;
        }

        table {
            border-collapse: collapse;
        }

        th {
            background-color: #009ADA;
            color: #FFFFFF;
            font-weight: normal;
            padding: 2px 5px;
        }

        td {
            padding: 2px 5px;
        }

        #message {
            border: 1px dashed #009ADA;
            border-radius: 5px;
            margin-bottom: 15px;
            margin-top: 15px;
            padding: 5px;
            text-align: center;
        }

        #worker-address-box {
            border-radius: 5px;
            float: left;
            margin-bottom: 25px;
            min-height: 155px;
            padding: 5px;
            width: 215px;
        }

        #agency-address-box {
            border: 1px solid #009ADA;
            border-radius: 5px;
            float: right;
            margin-bottom: 25px;
            width: 500px;
        }

        #address-box span {
            display: inline-block;
            width: 75px;
        }

        #agency-address-box .label {
            background: #009ADA;
            color: #fff;
            border-bottom: 1px solid #fff;
            float: left;
            width: 150px;
            padding: 4px;
        }

            #agency-address-box .label.nb {
                border-bottom: none;
            }

        #agency-address-box .value {
            float: left;
            padding: 4px;
        }

        #agency-address-box .row {
            clear: both;
        }

        .left-col {
            width: 300px;
            float: left;
            margin-right: 10px;
        }

        .right-col {
            width: 520px;
            float: left;
        }

        .small {
            font-size: 0.8em;
        }

        .col-content {
            padding: 10px;
            border-left: 1px solid #009ADA;
            border-right: 1px solid #009ADA;
        }

            .col-content.bottom {
                border-bottom: 1px solid #009ADA;
            }

            .col-content table tr td.right {
                text-align: right;
            }

        #ps_header {
            text-align: center;
            border-bottom: 2px solid #000;
            margin-bottom: 15px;
        }

        .doc-name {
            float: left;
            font-size: 1.2em;
        }
        #doc-info, .doc-info {
            float: right;
            padding-bottom: 20px;
        }

        .total-pay {
            border-radius: 5px;
            border: 2px solid #009ADA;
            font-size: 1.8em;
            text-align: right;
            font-weight: bold;
            padding: 10px;
            margin-top: 10px;
        }

        .address {
            width: 250px;
            padding-obottom: 10px;
        }

        .right {
            float: right;
        }

        .snip {
            border-bottom: 1px dashed #000;
            height: 20px;
            margin-bottom: 20px;
        }

        .full-width {
            width: 100%;
        }

        .text-left {
            text-align: left;
        }

        #ps_list tbody tr td {
            text-align: left;
        }

        .header .logo img {
            padding-bottom: 5px;
        }

        .header {
            padding-bottom: 10px;
            text-align: center;
            border-bottom: 2px solid #ccc;
            font-size: 8pt;
            padding-bottom: 30px;
        }

            .header p {
                margin: 0;
                padding: 0;
            }

        .ps_header {
            padding-bottom: 10px;
            text-align: center;
            border-bottom: 2px solid #ccc;
            font-size: 8pt;
        }
        .ps_header p {
            margin: 0;
            padding: 0;
        }

    .page-break{
       display: block;
       clear: both;
       page-break-after: always;
    }
        -->
    </style>
</head>
<body style=""color: #000000;font-family: Arial, Helvetica, sans-serif;font-size: 12px;margin: 0;padding: 0 20px;"">

    <div class=""ps_header"" style=""padding-bottom: 10px;text-align: center;border-bottom: 2px solid #ccc;font-size: 8pt;"">
    <img src="""" https: style=""border: 0;"">/jcwill5.files.wordpress.com/2015/09/infinity_symbol.jpg"""" class=""""logo clear"""" style=""""padding-bottom:30px;"""" />
            <p style=""margin: 0;padding: 0;"">
                    <span>Aayyyyyyyyyyy is a trading style of AY Professional Ltd</span><br>

                Address: yEA<br>

                        <span>Telephone: wooo, </span>
                    <span>Email Address: weee@woo.com</span><br>

                    <span>VAT Number: GB123145, </span>
                    <span>Company Number: 12312532</span><br>
            </p>
    </div>

<div id=""doc-info"" style=""padding-top: 20px;float: right;padding-bottom: 20px;"">
    Date: 12/12/12<br>
    Document Number: 214124
</div>
<div class=""clear"" style=""clear: both;""></div>

<div class=""address right"" style=""width: 250px;padding-obottom: 10px;float: right;"">
        <p>
            FROM<br>
            Luke's massive hijinx Ltd<br>
            lol street
        </p>
</div>

<div class=""address"" style=""width: 250px;padding-obottom: 10px;"">
    <p>
        <strong>John Smith</strong><br>
        loooooooooool<br>
        lololeerererton
    </p>
</div>

<div class=""clear"" style=""clear: both;""></div>
    <p style=""text-align: center;"">Any queries please call client support on @Model.GatewayProvider.TelephoneNumber</p>

<h4>Information</h4>
<table id=""ps_list"" class=""full-width"" style=""border-collapse: collapse;width: 100%;"">
    <thead>
        <tr>
            <th class=""text-left"" style=""background-color: #009ADA;color: #FFFFFF;font-weight: normal;padding: 2px 5px;text-align: left;"">Description</th>
            <th class=""text-left"" style=""background-color: #009ADA;color: #FFFFFF;font-weight: normal;padding: 2px 5px;text-align: left;"">Qty</th>
            <th class=""text-left"" style=""background-color: #009ADA;color: #FFFFFF;font-weight: normal;padding: 2px 5px;text-align: left;"">Unit Cost</th>
            <th class=""text-left"" style=""background-color: #009ADA;color: #FFFFFF;font-weight: normal;padding: 2px 5px;text-align: left;"">Amount</th>
            <th class=""text-left"" style=""background-color: #009ADA;color: #FFFFFF;font-weight: normal;padding: 2px 5px;text-align: left;"">Total</th>
        </tr>
    </thead>
    <tbody>
                <tr>
                    <td style=""padding: 2px 5px;text-align: left;"">@line.Description</td>
                    <td style=""padding: 2px 5px;text-align: left;"">5</td>
                    <td style=""padding: 2px 5px;text-align: left;"">&pound;50.00</td>
                    <td style=""padding: 2px 5px;text-align: left;"">&pound;250</td>
                    <td style=""padding: 2px 5px;text-align: left;"">&pound;250</td>
                </tr>
                <tr>
                    <td style=""padding: 2px 5px;text-align: left;"">@line.Description</td>
                    <td style=""padding: 2px 5px;text-align: left;"">5</td>
                    <td style=""padding: 2px 5px;text-align: left;"">&pound;50.00</td>
                    <td style=""padding: 2px 5px;text-align: left;"">&pound;250</td>
                    <td style=""padding: 2px 5px;text-align: left;"">&pound;250</td>
                </tr>
    </tbody>
</table>

<div class=""snip"" style=""border-bottom: 1px dashed #000;height: 20px;margin-bottom: 20px;""></div>
<div class=""clear"" style=""clear: both;""></div>

<div id=""doc-info"">
    Date: 10/12/12<br>
    Document Number: 1231244
</div>
<div class=""clear"" style=""clear: both;""></div>

<div id=""worker-address-box"" style=""border-radius: 5px;float: left;margin-bottom: 25px;min-height: 155px;padding: 5px;width: 215px;"">
    <strong>John Smith<br>
    yeee boi<br>
    yeeeeeeee
</strong></div>
<div id=""agency-address-box"" style=""border: 1px solid #009ADA;border-radius: 5px;float: right;margin-bottom: 25px;width: 500px;"">

        <div class=""row"" style=""clear: both;"">
            <div class=""label"" style=""background: #009ADA;color: #fff;border-bottom: 1px solid #fff;float: left;width: 150px;padding: 4px;"">Employer:</div>
            <div class=""value"" style=""float: left;padding: 4px;"">@Model.Payslip.PaymentCompany.Name</div>
        </div>
    <div class=""row"" style=""clear: both;"">
        <div class=""label"" style=""background: #009ADA;color: #fff;border-bottom: 1px solid #fff;float: left;width: 150px;padding: 4px;"">Employee:</div>
        <div class=""value"" style=""float: left;padding: 4px;"">@Model.Payslip.Employee.FirstName @Model.Payslip.Employee.Surname</div>
    </div>
    <div class=""row"" style=""clear: both;"">
        <div class=""label"" style=""background: #009ADA;color: #fff;border-bottom: 1px solid #fff;float: left;width: 150px;padding: 4px;"">ID:</div>
        <div class=""value"" style=""float: left;padding: 4px;"">@Model.Payslip.Employee.RealReference</div>
    </div>
    <div class=""row"" style=""clear: both;"">
        <div class=""label"" style=""background: #009ADA;color: #fff;border-bottom: 1px solid #fff;float: left;width: 150px;padding: 4px;"">NI No.:</div>
        <div class=""value"" style=""float: left;padding: 4px;"">@Model.Payslip.Employee.NiNumber</div>
    </div>
    <div class=""row"" style=""clear: both;"">
        <div class=""label"" style=""background: #009ADA;color: #fff;border-bottom: 1px solid #fff;float: left;width: 150px;padding: 4px;"">Tax Period:</div>
        <div class=""value"" style=""float: left;padding: 4px;"">1
        </div>
    </div>
    <div class=""row"" style=""clear: both;"">
        <div class=""label"" style=""background: #009ADA;color: #fff;border-bottom: 1px solid #fff;float: left;width: 150px;padding: 4px;"">Tax Code:</div>
        <div class=""value"" style=""float: left;padding: 4px;"">1150L W1</div>
    </div>
        <div class=""row"" style=""clear: both;"">
            <div class=""label nb"" style=""background: #009ADA;color: #fff;border-bottom: none;float: left;width: 150px;padding: 4px;"">PAYE Ref:</div>
            <div class=""value"" style=""float: left;padding: 4px;"">lol/lololololol</div>
        </div>
</div>

<div class=""clear"" style=""clear: both;""></div>

<div class=""left-col"" style=""width: 300px;float: left;margin-right: 10px;"">
    <div class=""box no-margin-b round-tl round-tr"" style=""background-color: #8DCEEF;border: 1px solid #009ADA;margin-bottom: 0;padding: 5px 10px;border-top-left-radius: 5px;border-top-right-radius: 5px;"">
        Statutory Additions
    </div>
    <div class=""col-content"" style=""padding: 10px;border-left: 1px solid #009ADA;border-right: 1px solid #009ADA;"">
        <table cellspacing=""0"" cellpadding=""0"" width=""100%"" style=""border-collapse: collapse;"">
            <tr>
                <td width=""60%"" style=""padding: 2px 5px;"">SSP</td>
                <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;5</td>
            </tr>
            <tr>
                <td style=""padding: 2px 5px;"">SMP</td>
                <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;9</td>
            </tr>
            <tr>
                <td style=""padding: 2px 5px;"">OSPP</td>
                <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;0.00</td>
            </tr>
            <tr>
                <td style=""padding: 2px 5px;"">ASPP</td>
                <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;0.00</td>
            </tr>
            <tr>
                <td style=""padding: 2px 5px;"">SAP</td>
                <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;.0.0.0</td>
            </tr>
            <tr>
                <td style=""padding: 2px 5px;"">Other</td>
                <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;0.00</td>
            </tr>
            <tr>
                <td style=""padding: 2px 5px;""><strong>Total Additions</strong></td>
                <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;.0.0.0.0</td>
            </tr>
        </table>
    </div>

    <div class=""box no-margin-b"" style=""background-color: #8DCEEF;border: 1px solid #009ADA;margin-bottom: 0;padding: 5px 10px;"">
            <text>Year to Date Taxable Pay</text>
    </div>
    <div class=""col-content bottom round-bl round-br"" style=""border-bottom-left-radius: 5px;border-bottom-right-radius: 5px;padding: 10px;border-left: 1px solid #009ADA;border-right: 1px solid #009ADA;border-bottom: 1px solid #009ADA;"">
        <table cellspacing=""0"" cellpadding=""0"" width=""100%"" style=""border-collapse: collapse;"">
            <tr>
                <td width=""65%"" style=""padding: 2px 5px;"">YTD Taxable Pay</td>
                <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;3252</td>
            </tr>
            <tr>
                <td style=""padding: 2px 5px;"">YTD Tax Paid</td>
                <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;436436</td>
            </tr>
        </table>
    </div>

        <div class=""box no-margin-b"" style=""background-color: #8DCEEF;border: 1px solid #009ADA;margin-bottom: 0;padding: 5px 10px;"">
            Personal Tax Relief Note
        </div>
        <div class=""col-content small bottom round-bl round-br"" style=""border-bottom-left-radius: 5px;border-bottom-right-radius: 5px;font-size: 0.8em;padding: 10px;border-left: 1px solid #009ADA;border-right: 1px solid #009ADA;border-bottom: 1px solid #009ADA;"">
            <p>
                By submitting a claim for genuine business expenses to us in accordance with our policy, we will action this claim by
                disregarding a proportion of the amount due to you from PAYE and NIC. No additional claim for tax relief should be made to
                HM Revenue and Customs in respect of expenses incurred which are the subject of such claim. For the avoidance of doubt, we
                do not re-imburse expenses.
            </p>
        </div>

        <p><strong>Holiday Pay Accrued:</strong> &pound;59.23</p>
    
        <p><strong>Holiday Pay Balance:</strong> &pound;35.23</p>
    
        <p><strong>Hours Worked: </strong> 69,000</p>

</div>

<div class=""right-col"" style=""width: 520px;float: left;"">
    <div class=""box no-margin-b round-tl round-tr"" style=""background-color: #8DCEEF;border: 1px solid #009ADA;margin-bottom: 0;padding: 5px 10px;border-top-left-radius: 5px;border-top-right-radius: 5px;"">
        Statutory Deductions
    </div>
    <div class=""col-content"" style=""padding: 10px;border-left: 1px solid #009ADA;border-right: 1px solid #009ADA;"">
        <table cellspacing=""0"" cellpadding=""0"" width=""100%"" style=""border-collapse: collapse;"">
            <tr>
                <td width=""65%"" style=""padding: 2px 5px;"">PAYE Tax</td>
                    <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;345.12</td>
            </tr>
            <tr>
                <td style=""padding: 2px 5px;"">Employee's NI</td>
                    <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;345.12</td>
            </tr>
            <tr>
                <td style=""padding: 2px 5px;"">SLR</td>
                    <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;345.12</td>
            </tr>
                <tr>
                    <td style=""padding: 2px 5px;"">Postgraduate Loan</td>
                    <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;345.12</td>
                </tr>
            <tr>
                <td style=""padding: 2px 5px;"">AOE</td>
                    <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;345.12</td>
            </tr>

            <tr>
                <td style=""padding: 2px 5px;"">Pension</td>
                <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;@Model.Payslip.Pension.RoundUp().ToString(""N2"")</td>
            </tr>

            <tr>
                <td style=""padding: 2px 5px;"">Other</td>
                    <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;345.12</td>
            </tr>
            <tr>
                <td style=""padding: 2px 5px;"">&nbsp;</td>
                <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&nbsp;</td>
            </tr>
            <tr>
                <td style=""padding: 2px 5px;""><strong>Total Deductions</strong></td>
                    <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;345.12</td>
            </tr>
        </table>
    </div>
    <div class=""box no-margin-b"" style=""background-color: #8DCEEF;border: 1px solid #009ADA;margin-bottom: 0;padding: 5px 10px;"">
        Breakdown
    </div>
    <div class=""col-content bottom round-br round-bl"" style=""border-bottom-left-radius: 5px;border-bottom-right-radius: 5px;padding: 10px;border-left: 1px solid #009ADA;border-right: 1px solid #009ADA;border-bottom: 1px solid #009ADA;"">
        <table cellspacing=""0"" cellpadding=""0"" width=""100%"" style=""border-collapse: collapse;"">
            <tr>
                <td width=""65%"" style=""padding: 2px 5px;"">Gross Salary</td>
                    <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;345.12</td>
            </tr>
            <tr>
                <td width=""65%"" style=""padding: 2px 5px;"">Gross for Tax</td>
                    <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;69.69</td>
            </tr>
            <tr>
                <td style=""padding: 2px 5px;"">Statutory Additions</td>
                    <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;345.12</td>
            </tr>
            <tr>
                <td style=""padding: 2px 5px;""><strong>Sub Total</strong> <small>(Including Statutory Additions)</small></td>
                    <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;345.12</td>
            </tr>
            <tr>
                <td style=""padding: 2px 5px;"">Statutory Deductions</td>
                    <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;345.12</td>
            </tr>
            <tr>
                <td style=""padding: 2px 5px;"">&nbsp;</td>
                <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&nbsp;</td>
            </tr>
            <tr>
                <td style=""padding: 2px 5px;""><strong>Net Pay</strong></td>
                    <td class=""right"" style=""padding: 2px 5px;float: right;text-align: right;"">&pound;345.12</td>
            </tr>
        </table>
    </div>
    <div class=""total-pay"" style=""border-radius: 5px;border: 2px solid #009ADA;font-size: 1.8em;text-align: right;font-weight: bold;padding: 10px;margin-top: 10px;"">
        &pound;696969696.9
    </div>
</div>

    <p style=""text-align: center; padding-top: 15px; clear:both; float: left;"">
        yo bitches I'm a payslip
    </p>

<div class=""clear"" style=""clear: both;""></div>

    <p class=""text-center"" style=""margin-bottom: 0;text-align: center;"">
        <strong>IMPORTANT NOTICE</strong><br>
        This pay advice includes calculations for tax relief provided by a third party (Rudi's big bad expense co).<br>
        It is important that you read, understand and retain the ATTACHED STATEMENT provided to us by Lee's Expense Mumbajumba as attached.
    </p>

    <div class=""page-break"" style=""display: block;clear: both;page-break-after: always;""></div>
    <style type=""text/css"">
        h2 {
            background-color: #CCCCCC;
            font-size: 14px;
            margin: 0;
            padding: 5px 10px;
        }

        #expense-balance td {
            line-height: 35px;
        }

        .header .logo img {
            padding-bottom: 5px;
        }

        .header {
            padding-bottom: 10px;
            text-align: center;
            border-bottom: 2px solid #ccc;
            font-size: 8pt;
        }

            .header p {
                margin: 0;
                padding: 0;
            }

        img {
            border: 0;
        }
    </style>


    <div id=""doc-info"">
        Date: @Model.Payslip.ProcessDate.ToShortDateString()<br>
        Document Number: @Convert.ToString(Model.Payslip.PayslipId).PadLeft(10, '0')
    </div>

    <div class=""clear"" style=""clear: both;""></div>

    <p>
        <strong>@Model.Payslip.Employee.FirstName @Model.Payslip.Employee.Surname</strong><br>
        @Model.Payslip.Employee.AddressLine1<br>
        @if (!string.IsNullOrEmpty(Model.Payslip.Employee.AddressLine2))
        {<span>@Model.Payslip.Employee.AddressLine2 <br></span>}
        @Model.Payslip.Employee.City<br>
        @Model.Payslip.Employee.PostCode<br>
        @Model.Payslip.Employee.County
    </p>

        <h2 style=""background-color: #CCCCCC;font-size: 14px;margin: 0;padding: 5px 10px;"">Expenses claimed for purpose of personal tax relief</h2>
        <div style=""margin: 10px;"">
            <table id=""expense-balance"" cellpadding=""2"" cellspacing=""0"" width=""100%"" style=""border-collapse: collapse;"">
                <tr>
                    <td style=""padding: 2px 5px;line-height: 35px;""><strong>Total expenses claimed for personal tax relief</strong></td>
                    <td class=""text-right"" style=""padding: 2px 5px;text-align: right;line-height: 35px;""><strong>&pound;69</strong></td>
                </tr>
            </table>
        </div>

        <h2 style=""background-color: #CCCCCC;font-size: 14px;margin: 0;padding: 5px 10px;"">Other</h2>
        <div style=""margin: 10px;"">
            <table cellpadding=""2"" cellspacing=""0"" width=""100%"" style=""border-collapse: collapse;"">
                @foreach (var fee in payslipService.GetPostPayrollElements())
                {
                    <tr>
                        <td style=""padding: 2px 5px;"">@(fee.Description == ""Additional Fee"" && Model.ExpenseProvider != null ? Model.ExpenseProvider.Name + "" Rewards Fee"" : fee.Description)</td>
                        <td class=""right"" style=""padding: 2px 5px;float: right;"">&pound;345.12</td>
                    </tr>
                }
            </table>
        </div>

    <h2 style=""background-color: #CCCCCC;font-size: 14px;margin: 0;padding: 5px 10px;"">Summary</h2>

    <div style=""margin: 10px;"">
        <table cellpadding=""2"" cellspacing=""0"" width=""100%"" style=""border-collapse: collapse;"">
                <tr>
                    <td style=""padding: 2px 5px;"">Net wage before tax relief applied</td>
                    <td class=""text-right"" style=""padding: 2px 5px;text-align: right;"">&pound;@Model.Payslip.OriginalNet.RoundUp().ToString(""N2"")</td>
                </tr>
                <tr>
                    <td style=""padding: 2px 5px;"">Net wage after tax relief applied</td>
                    <td class=""text-right"" style=""padding: 2px 5px;text-align: right;"">&pound;@(payslipService.GetPayslipNet().RoundUp().ToString(""N2""))</td>
                </tr>
                    <tr>
                        <td style=""padding: 2px 5px;"">PTR processing fee</td>
                        <td class=""text-right"" style=""padding: 2px 5px;text-align: right;"">&pound;@Model.Payslip.Margin.RoundUp().ToString(""N2"")</td>
                    </tr>
                        <tr>
                            <td style=""padding: 2px 5px;"">VAT @ @(Model.Payslip.VatRate * 100)%</td>
                            <td class=""text-right"" style=""padding: 2px 5px;text-align: right;"">&pound;@Model.Payslip.MarginVat.RoundUp().ToString(""N2"")</td>
                        </tr>
            <tr>
                <td style=""padding: 2px 5px;""><strong>Paid</strong></td>
                <td class=""text-right"" style=""padding: 2px 5px;text-align: right;""><strong>&pound;@Model.Payslip.Net.RoundUp().ToString(""N2"")</strong></td>
            </tr>

            @if (Model.Payslip.Expenses > 0 && Model.Payslip.NetBenefit > 0)
            {
                <tr>
                    <td style=""padding: 2px 5px;"">Net benefit to worker</td>
                    <td class=""text-right"" style=""padding: 2px 5px;text-align: right;"">&pound;@Model.Payslip.NetBenefit.RoundUp().ToString(""N2"")</td>
                </tr>
            }
        </table>
    </div>

        <h3>IMPORTANT</h3>
        <p>
            The expenses claimed above are as advised by you to @Model.ExpenseProvider.Name.
            If your circumstances have changed, or if any details are incorrect, you must inform us by @(Model.HideTelephoneNumber ? ""email to "" + @Model.ExpenseProvider.EmailAddress
: ""phone on "" + @Model.ExpenseProvider.TelephoneNumber + "" or by email to "" + @Model.ExpenseProvider.EmailAddress), before your payment is made on Friday.
            @Model.ExpenseProvider.Name will conduct verification checks on a periodic basis to ensure that expenses claimed are correct and qualifying for tax relief.
            Incorrect claims could lead to disciplinary proceedings by the employer and a tax liability for the individual.
        </p>
}

</body>
</html>";
                var pdf = TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerator.GeneratePdf(html, PdfSharpCore.PageSize.A4);
                pdf.Save(ms);

                ms.Flush();
            }
        }
    }
}
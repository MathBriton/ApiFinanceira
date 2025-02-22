using Fina.Domain.Handlers;
using Fina.Domain.Models.Reports;
using Fina.Domain.Requests.Reports;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Fina.Web.Pages;

public partial class HomePage : ComponentBase
{
    #region Properties

    public bool ShowValues { get; set; } = true;
    public FinancialSummary? Summary { get; set; }

    #endregion

    #region Services

    [Inject]
    public ISnackbar Snackbar { get; set; } = null!;

    [Inject]
    public IReportHandler Handler { get; set; } = null!;

    #endregion

    #region Overrides

    protected override async Task OnInitializedAsync()
    {
        var request = new GetFinancialSummaryRequest();
        var result = await Handler.GetFinancialSummaryReportAsync(request);
        if (result.IsSuccess)
            Summary = result.Data;
    }

    #endregion

    #region Methods

    public void ToggleShowValues() 
        => ShowValues = !ShowValues;

    #endregion
}
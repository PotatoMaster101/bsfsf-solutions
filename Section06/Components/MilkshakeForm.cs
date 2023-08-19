using Microsoft.AspNetCore.Components;
using Section06.Models;
using Section06.Services;

namespace Section06.Components;

public partial class MilkshakeForm
{
    private readonly MilkshakeModel _model = new();
    private string _message = string.Empty;
    private List<MilkshakeType> _milkshakeTypes = new();

    [Inject]
    public ILogger<MilkshakeForm> Logger { get; set; } = default!;

    [Inject]
    public IMilkshakeTypeRepository MilkshakeTypeRepo { get; set; } = default!;

    public Guid SelectedMilkshakeTypeId
    {
        get => _model.Type.Id;
        set
        {
            var type = _milkshakeTypes.First(x => x.Id == value);
            _model.Type = type;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        _milkshakeTypes.AddRange(await MilkshakeTypeRepo.GetAll());
        _model.Type = _milkshakeTypes[0];
        await base.OnInitializedAsync();
    }

    private void HandleInvalidSubmit()
    {
        _message = string.Empty;
    }

    private void HandleValidSubmit()
    {
        Logger.LogInformation("Valid form submit: {Name}", _model.Name);
        _message = $"Order {_model.Name} submitted";
    }
}

using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace BattleOfStrategies.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("slider")]
    public class SliderTagHelper : TagHelper
    {
        public string Min { get; set; } = "0.1";
        public string Max { get; set; } = "0.9";
        public string Step { get; set; } = "0.1";

        [HtmlAttributeName("for-name")]
        public ModelExpression For { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("class", "form-group");

            string id = $"slider-{For.Name.ToLower()}";

        output.Content.SetHtmlContent(
            $@"
                <div class=""d-inline-flex align-items-center"">
                    <label for=""{For.Name}"" class=""text-center form-label me-2 h2"">{For.Name}</label>
                    <output class=""input-group-text ms-3 pt-1 pb-1 p-2 border-3"" id=""{id}"">{Min}</output>
                </div>
                <input for=""{For.Name}"" class=""form-range"" type=""range"" min=""{Min}"" max=""{Max}"" step=""{Step}"" value=""{Min}"" onload=""updateSliderValue(this.value, `{id}`)"" oninput=""updateSliderValue(this.value, `{id}`)"">"
                );

            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}

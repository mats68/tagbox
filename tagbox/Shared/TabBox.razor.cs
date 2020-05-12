using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tagbox.Shared
{
    public class TabBoxBase : ComponentBase
    {
        public string Skills { get; set; } = "HTML,CSS";

        public void TagsChanged(IEnumerable<string> newTags)
        {
            if (newTags != null)
            {
                Skills = string.Join(',', newTags);
                SkillData = Skills.Split(',').ToList();
                SkillSelected = Skills.Split(',').ToList();
                InvokeAsync(StateHasChanged);
            }
            else
            {
                Skills = null;
            }

        }
        public IEnumerable<string> SkillData = new List<string>();
        public IEnumerable<string> SkillSelected = new List<string>();

        protected override void OnInitialized()
        {
            if (Skills != null)
            {
                SkillData = Skills.Split(',').ToList();
                SkillSelected = Skills.Split(',').ToList();
            }

        }


    }


}

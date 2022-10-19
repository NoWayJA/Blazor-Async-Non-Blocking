using System;
namespace Good_Bad_Awaiting.Pages
{
    public partial class Index
    {
        private string YourName = "Mr Blobby";
        private string block1 = "";
        private string block2 = "";
        private string block3 = "";
        private string block4 = "";
        private string block5 = "";
        private string block6 = "";
        public Index()
        {
        }
        private async Task Master1()
        {
            ClearBlocks();
            await Block1();
            await Block2();
            await Block3();
            await Block4();
            await Block5();
            await Block6();
        }

        private async Task Master2()
        {
            ClearBlocks();
            Block1();
            Block2();
            Block3();
            Block4();
            Block5();
            Block6();
        }



        private void ClearBlocks()
        {
             block1 = "";
             block2 = "";
             block3 = "";
             block4 = "";
             block5 = "";
             block6 = "";
            StateHasChanged();
        }

        private async Task Block1()
        {
            await Task.Delay(1000);
            block1 = "block1 set";
            StateHasChanged();
        }
        private async Task Block2()
        {
            await Task.Delay(1000);
            block2 = "block2 set";
            StateHasChanged();
        }
        private async Task Block3()
        {
            await Task.Delay(1000);
            block3 = "block3 set";
            StateHasChanged();
        }
        private async Task Block4()
        {
            await Task.Delay(1000);
            block4 = "block4 set";
            StateHasChanged();
        }
        private async Task Block5()
        {
            await Task.Delay(1000);
            block5 = "block5 set";
            StateHasChanged();
        }
        private async Task Block6()
        {
            await Task.Delay(1000);
            block6 = "block6 set";
            StateHasChanged();
        }
    }
}


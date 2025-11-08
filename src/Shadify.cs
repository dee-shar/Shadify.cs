using System.Net.Http;

namespace ShadifyApi
{
    public class Shadify
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://shadify.yurace.pro/api";
        public Shadify()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GenerateSudoku()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/sudoku/generator");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> CheckSudoku(string task)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/sudoku/verifier?task={task}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GenerateTakuzu()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/takuzu/generator");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> CheckTakuzu(string task)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/takuzu/verifier?task={task}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetAllSetCards()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/set/start");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> LoadSetState(string state)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/set/{state}");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> GenerateSchulte()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/schulte/generator");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GenerateMineSweeper()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/minesweeper/generator");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GenerateWordSearch()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/wordsearch/generator");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GenerateAnagram()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/anagram/generator");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GenerateCapitalQuiz()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/countries/capital-quiz");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GenerateCountryQuiz()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/countries/country-quiz");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GenerateCamp()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/camp/generator");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GenerateKuromasu()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/kuromasu/generator");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GenerateMemory()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/memory/generator");
            return await response.Content.ReadAsStringAsync();
        }
    }
}

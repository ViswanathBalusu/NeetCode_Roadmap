//Link: https://leetcode.com/problems/valid-sudoku/

public class SolutionValidSusodku {
    public bool IsValidSudoku(char[][] board) {
        var cols = new HashSet<int>[9];
        var rows = new HashSet<int>[9];
        var subArr = new HashSet<int>[3,3];

        for(int i=0; i<board.Length; i++){
        	for(int j=0; j<board[0].Length; j++){ //Iterate Through Sudoku

        		if(board[i][j] == '.'){ //Skip if No element
        			continue;
        		}

        		if (rows[i] == null){ // if the element at index is not intialized 
        			rows[i] = new HashSet<int>();
        		}

        		if (cols[j] == null){
        			cols[j] = new HashSet<int>();
        		}

        		if (subArr[i/3,j/3] == null){
        			subArr[i/3,j/3] = new HashSet<int>();
        		}

        		// Check if it is duplicate

        		if (rows[i].Contains(board[i][j]) || cols[j].Contains(board[i][j]) || subArr[i/3, j/3].Contains(board[i][j])){
        			return false;
        		}

        		//add the element to all the dicts, if the above condition fails

        		rows[i].Add(board[i][j]);
        		cols[j].Add(board[i][j]);
        		subArr[i/3, j/3].Add(board[i][j]);
        	}
        }
        return true;
    }
}
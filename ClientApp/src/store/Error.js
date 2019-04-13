export const createError = "CREATE_ERROR";
export const clearError = "CLEAR_ERROR";

const initalState = {errorMessage:undefined}

export const errorActionCreators = {
	createError:msg => (dispatch)=>{
		dispatch({type:createError, errorMessage:msg});
	},
	clearError: ()=> (dispatch)=>{
		dispatch({type:clearError});
	}
}

export const reducer  = (state, action)=>{
	switch(action.type){
		case createError:
			return {...state, errorMessage:action.errorMessage};
		case clearError:
			return initalState;
		default:
			return state || initalState;
	}
}

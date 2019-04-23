import { applyMiddleware, combineReducers, compose, createStore } from 'redux';
import thunk from 'redux-thunk';
import { routerReducer, routerMiddleware } from 'react-router-redux';
import * as School from "./School";
import * as Search from "./Search";
import * as Loading from "./Loading";
import * as Error from "./Error";

//Much of this code is automatically generated at the begining of a project
//It sets up the global reducer store lookup and adds in the thunk middleware (which is used for async actions)
//Also configures debugging tools
export default function configureStore (history, initialState) {
  const reducers = {
      school: School.reducer,
      search: Search.reducer,
      loading: Loading.reducer,
	  error: Error.reducer
  };

  const middleware = [
    thunk,
    routerMiddleware(history)
  ];

  // In development, use the browser's Redux dev tools extension if installed
  const enhancers = [];
  const isDevelopment = process.env.NODE_ENV === 'development';
  if (isDevelopment && typeof window !== 'undefined' && window.devToolsExtension) {
    enhancers.push(window.devToolsExtension());
  }

  const rootReducer = combineReducers({
    ...reducers,
    routing: routerReducer
  });

  return createStore(
    rootReducer,
    initialState,
    compose(applyMiddleware(...middleware), ...enhancers)
  );
}

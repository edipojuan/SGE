import { createReducer, on } from '@ngrx/store';

import * as actions from '../actions/lecture.actions';

export const initialState: any = {};

const reducer = createReducer(
  initialState,
  on(actions.updateLecture, (state, { response }) => {
    return {
      ...state,
      lecture: response
    };
  })
);

export function lectureReducer(state: any, action: any) {
  return reducer(state, action);
}

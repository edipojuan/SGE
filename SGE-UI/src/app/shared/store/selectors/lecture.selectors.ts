import { createSelector } from '@ngrx/store';

export const selectLecture = (state: any) => state.lectureReducer;

export const selectName = createSelector(
  selectLecture,
  (state: any) => state.name
);

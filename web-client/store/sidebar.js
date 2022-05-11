export const state = () => ({
  isCollapsed: false,
})

export const mutations = {
  update(state) {
    state.isCollapsed = !state.isCollapsed;
  },
}

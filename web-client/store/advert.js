export const state = () => ({
  adverts: [],
})

export const mutations = {
  add(state, object) {
    state.adverts.push(object)
  },
}

export const state = () => ({
  modalOpenId: 0,
})

export const mutations = {
  update(state, id) {
    state.modalOpenId = id;
  },
}

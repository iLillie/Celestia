<template>
  <button class="text-gray-600 text-2xl p-2 leading-none rounded hover:bg-slate-50 hover:text-gray-800"
          :class="{ 'icon-shadow': hasShadow}" @click="$emit('onClick')">
    <span :class="icon"></span>
  </button>
</template>

<script>
export default {
  name: "IconButton",
  props: {
    icon: '',
    onclick: {
      type: () => {}
    },
    hasShadow: false
  }
}
</script>

<style scoped>
  .icon-shadow {
    box-shadow: 0px 0px 1px rgba(0, 0, 0, 0.2), 0px 0px 3px rgba(0, 0, 0, 0.05);
  }
</style>
